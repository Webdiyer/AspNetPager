using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ObjectDataSource_Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            AspNetPager1.RecordCount = OrderInfo.GetOrderCount();
        }
    }

    protected void ODS_Selecting(object src, ObjectDataSourceSelectingEventArgs e)
    {
        if (!e.ExecutingSelectCount)
        {
            e.Arguments.StartRowIndex = AspNetPager1.StartRecordIndex;
            e.Arguments.MaximumRows = AspNetPager1.PageSize;
        }
    }

}
