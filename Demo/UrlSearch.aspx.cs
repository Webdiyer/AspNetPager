using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UrlSearch_Default : Page
{
    private int minId=0;
    protected void Page_Load(object sender, EventArgs e)
    {
        string cmd = "select count(*) from orders";
        if (int.TryParse(Request.QueryString["minid"], out minId) && minId > 0)
        {
            cmd = "select count(*) from orders where orderid>=" + minId;
            btn_all.Enabled = true;
        }
        else
            btn_all.Enabled = false;
        AspNetPager1.RecordCount = (int) SqlHelper.ExecuteScalar(CommandType.Text, cmd);
    }

    protected void btn_search_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx?minid="+tb_orderid.Text);
    }


    protected void btn_all_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        string cmd =
            "select O.orderid,O.orderdate,O.customerid,C.CompanyName,E.FirstName+' '+E.LastName as EmployeeName from orders O left outer join Customers C on O.CustomerID=C.CustomerID left outer join Employees E on O.EmployeeID=E.EmployeeID order by orderid desc";
        if (minId > 0)
        {
            cmd =
                "select O.orderid,O.orderdate,O.customerid,C.CompanyName,E.FirstName+' '+E.LastName as EmployeeName from orders O left outer join Customers C on O.CustomerID=C.CustomerID left outer join Employees E on O.EmployeeID=E.EmployeeID where O.orderid>=" +
                minId + " order by orderid desc";
            tb_orderid.Text = minId.ToString();
        }
        SqlDataSource1.SelectCommand = cmd;
        DataView dv = (DataView) SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        AspNetPager1.RecordCount = dv.Count;

        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = dv;
        pds.AllowPaging = true;
        pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
        pds.PageSize = AspNetPager1.PageSize;
        Repeater1.DataSource = pds;
        Repeater1.DataBind();
    }
}

