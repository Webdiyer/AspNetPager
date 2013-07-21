using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Wuqi.Webdiyer;

public partial class CurrentPageIndex_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //cache the number of total records to improve performance
            object obj = Cache[GetType() + "totalOrders"];
            if (obj == null)
            {
                int totalOrders = (int) SqlHelper.ExecuteScalar(CommandType.StoredProcedure, "P_GetOrderNumber");
                Cache[GetType() + "totalOrders"] = totalOrders;
                obj = totalOrders;
            }
            AspNetPager1.RecordCount = (int) obj;
            bindData();
        }
    }

    void bindData()
    {
        GridView1.DataSource = SqlHelper.ExecuteReader(CommandType.StoredProcedure, ConfigurationManager.AppSettings["pagedSPName"],
            new SqlParameter("@startIndex", AspNetPager1.StartRecordIndex),
            new SqlParameter("@endIndex", AspNetPager1.EndRecordIndex));
        GridView1.DataBind();
        AspNetPager1.CustomInfoHTML = "Page  <font color=\"red\"><b>" + AspNetPager1.CurrentPageIndex + "</b></font> of  " + AspNetPager1.PageCount;
        AspNetPager1.CustomInfoHTML += "&nbsp;&nbsp;Orders " + AspNetPager1.StartRecordIndex + "-" + AspNetPager1.EndRecordIndex;
    }

    protected void AspNetPager1_PageChanged(object src, EventArgs e)
    {
        bindData();
    }
    protected void Button1_Click(object src,EventArgs e)
    {
        try
        {
            int pageindex = int.Parse(tb_pageindex.Text);
            AspNetPager1.GoToPage(pageindex);
        }
        catch(FormatException)
        {
            lbl_error.Text = "输入的页索引格式不正确";
        }
    }
}
