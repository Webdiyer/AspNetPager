using System;
using System.Collections.Generic;
using System.Web.UI;

public partial class ImageButtons_Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            AspNetPager1.RecordCount = OrderData.GetOrderCount();
            bindData();
        }
    }

    void bindData()
    {
        List<Order> orders = OrderData.GetPagedOrders(AspNetPager1.StartRecordIndex, AspNetPager1.EndRecordIndex);
        GridView1.DataSource = orders;
        GridView1.DataBind();
    }

    protected void AspNetPager1_PageChanged(object src,EventArgs e)
    {
        bindData();
    }
}
