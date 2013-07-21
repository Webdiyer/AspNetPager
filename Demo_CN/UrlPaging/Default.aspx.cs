using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

public partial class UrlPaging_Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //cache the number of total records to improve performance
            object obj = Cache[GetType()+"totalOrders"];
            if (obj == null)
            {
                int totalOrders = (int)SqlHelper.ExecuteScalar(CommandType.StoredProcedure, "P_GetOrderNumber");
                Cache[GetType()+"totalOrders"] = totalOrders;
                AspNetPager1.RecordCount = totalOrders;
            }
            else
            {
                AspNetPager1.RecordCount = (int)obj;
            }
        }
    }

    
    protected void AspNetPager1_PageChanged(object src, EventArgs e)
    {
        GridView1.DataSource = SqlHelper.ExecuteReader(CommandType.StoredProcedure, ConfigurationManager.AppSettings["pagedSPName"],
            new SqlParameter("@startIndex", AspNetPager1.StartRecordIndex),
            new SqlParameter("@endIndex", AspNetPager1.EndRecordIndex));
        GridView1.DataBind();
    }
}
