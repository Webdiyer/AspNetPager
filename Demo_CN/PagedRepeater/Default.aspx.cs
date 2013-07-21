using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class PagedRepeater_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int totalOrders = (int)SqlHelper.ExecuteScalar(CommandType.StoredProcedure, "P_GetOrderNumber");
            AspNetPager1.RecordCount = totalOrders;
            //bindData(); //使用url分页，只需在分页事件处理程序中绑定数据即可，无需在Page_Load中绑定，否则会导致数据被绑定两次
        }
    }

    void bindData()
    {
        Repeater1.DataSource = SqlHelper.ExecuteReader(CommandType.StoredProcedure, ConfigurationManager.AppSettings["pagedSPName"],
            new SqlParameter("@startIndex", AspNetPager1.StartRecordIndex),
            new SqlParameter("@endIndex", AspNetPager1.EndRecordIndex));
        Repeater1.DataBind();
    }

    protected void AspNetPager1_PageChanged(object src, EventArgs e)
    {
        bindData();
    }
}
