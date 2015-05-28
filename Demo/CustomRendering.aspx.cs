using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Web.UI;

public partial class CustomRendering_Default : Page
{
    OleDbConnection conn;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("app_data/northwnd.mdb;"));
            OleDbCommand cmd = new OleDbCommand("select count(*) from orders", conn);
            if (conn.State != ConnectionState.Open)
                conn.Open();
            AspNetPager1.RecordCount = (int)cmd.ExecuteScalar();
            conn.Close();
            bindData();
        }
    }

    void bindData()
    {
        conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("app_data/northwnd.mdb;"));
        OleDbDataAdapter cmd = new OleDbDataAdapter("select orderid,orderdate,customerid,employeeID from orders order by orderid desc", conn);
        DataTable tbl = new DataTable();
        cmd.Fill(tbl);
        int startIndex = AspNetPager1.StartRecordIndex;
        StringBuilder sb = new StringBuilder();
        sb.Append("<table width=\"100%\" border=\"0\"><tr><th>Order ID</th><th>Order Date</th><th>Customer ID</th><th>Employee ID</th></tr>");
        DataRow row;
        while (startIndex <= AspNetPager1.EndRecordIndex)
        {
            row = tbl.Rows[startIndex-1];
            sb.Append("<tr><td>");
            sb.Append(row[0]).Append("</td><td>");
            sb.AppendFormat("{0:d}",row[1]).Append("</td><td>");
            sb.Append(row[2]).Append("</td><td>");
            sb.Append(row[3]).Append("</td><td></tr>");
            startIndex++;
        }
        sb.Append("</table>");
        PlaceHolder1.Controls.Add(new LiteralControl(sb.ToString()));
    }

    protected void AspNetPager1_PageChanged(object src, EventArgs e)
    {
        bindData();
    }
}
