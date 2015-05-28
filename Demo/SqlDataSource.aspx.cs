using System;
using System.Data;
using System.Web.UI;

public partial class DataSources_Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int totalOrders = (int)SqlHelper.ExecuteScalar(CommandType.StoredProcedure, "P_GetOrderNumber");
            AspNetPager1.RecordCount = totalOrders;
        }
    }
}
