using System;
using System.Web.UI;
using Wuqi.Webdiyer;

public partial class Basic_Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //assuming the total record number you want to page through is 288
            AspNetPager1.RecordCount = 288;
        }
    }


    protected void AspNetPager1_PageChanging(object src, PageChangingEventArgs e)
    {
        if (CheckBox1.Checked)
            e.Cancel = true;
        label1.Text = "PageChanging event fired,value of the NewPageIndex is " + e.NewPageIndex;
    }

    protected void AspNetPager1_PageChanged(object src, EventArgs e)
    {
        label2.Text = "PageChanged event fired,current page index is " + AspNetPager1.CurrentPageIndex;
    }
}
