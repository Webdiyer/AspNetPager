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
        //如果是最后一页，则重新设置起始记录索引，以使最后一页的记录数与其它页相同，如总记录有101条，每页显示10条，如果不使用此方法，则第十一页即最后一页只有一条记录，使用此方法可使最后一页同样有十条记录。
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
