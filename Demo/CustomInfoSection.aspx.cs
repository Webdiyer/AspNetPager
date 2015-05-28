using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

public partial class CustomInfoSection_Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int totalOrders = (int)SqlHelper.ExecuteScalar(CommandType.StoredProcedure, "P_GetOrderNumber");
            AspNetPager1.RecordCount = totalOrders;
            bindData();
        }
    }

    void bindData()
    {
        DataList1.DataSource = SqlHelper.ExecuteReader(CommandType.StoredProcedure, ConfigurationManager.AppSettings["pagedSPName"],
            new SqlParameter("@startIndex", AspNetPager1.StartRecordIndex),
            new SqlParameter("@endIndex", AspNetPager1.EndRecordIndex));
        DataList1.DataBind();
    }
    protected void AspNetPager1_PageChanged(object src, EventArgs e)
    {
        bindData();
    }
}
