using System;
using System.Collections.Generic;
using System.Web.UI;

public partial class NTier_Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            AspNetPager1.RecordCount = OrderInfo.GetOrderCount();
            bindData();
        }
    }

    void bindData()
    {
        List<Order> orders = OrderInfo.GetPagedOrders(AspNetPager1.StartRecordIndex, AspNetPager1.PageSize);
        DataList1.DataSource = orders;
        DataList1.DataBind();
    }

    protected void AspNetPager1_PageChanged(object src, EventArgs e)
    {
        bindData();
    }
}
