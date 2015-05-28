using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

public partial class ReverseUrlPageIndex_Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //cache the number of total records to improve performance
            object obj = Cache[GetType()+"totalOrders"];
            if (obj == null)
            {
                int totalOrders = (int) SqlHelper.ExecuteScalar(CommandType.StoredProcedure, "P_GetOrderNumber");
                Cache[GetType()+"totalOrders"] = totalOrders;
                AspNetPager1.RecordCount = totalOrders;
            }
            else
            {
                AspNetPager1.RecordCount = (int) obj;
            }
        }
    }


    protected void AspNetPager1_PageChanged(object src, EventArgs e)
    {
        int startIndex = AspNetPager1.StartRecordIndex;
        if (AspNetPager1.CurrentPageIndex == AspNetPager1.PageCount)
            startIndex = AspNetPager1.RecordCount - AspNetPager1.PageSize+1;
        GridView1.DataSource = SqlHelper.ExecuteReader(CommandType.StoredProcedure, ConfigurationManager.AppSettings["pagedSPName"],
            new SqlParameter("@startIndex", startIndex),
            new SqlParameter("@endIndex", AspNetPager1.EndRecordIndex));
        GridView1.DataBind();
        AspNetPager1.CustomInfoHTML = "Page  <font color=\"red\"><b>" + AspNetPager1.CurrentPageIndex + "</b></font> of  " + AspNetPager1.PageCount;
        AspNetPager1.CustomInfoHTML += "&nbsp;&nbsp;Orders " + AspNetPager1.StartRecordIndex + "-" + AspNetPager1.EndRecordIndex;
    }
    
}
