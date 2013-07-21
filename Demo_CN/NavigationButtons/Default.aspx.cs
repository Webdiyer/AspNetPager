using System;
using System.Web.UI;

public partial class NavigationButtons_Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack)
        {
            AspNetPager1.ShowFirstLast = ck_firstlast.Checked;
            AspNetPager1.ShowPrevNext = ck_prevnext.Checked;
            AspNetPager1.ShowPageIndex = ck_pageindex.Checked;
            AspNetPager1.ShowDisabledButtons = ck_disbtn.Checked;
        }

    }
}
