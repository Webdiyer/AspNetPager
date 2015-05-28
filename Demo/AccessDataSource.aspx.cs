using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataSources_PagedDataSrc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindData();
        }
    }

    void bindData()
    {
        PagedDataSource pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.PageSize = AspNetPager1.PageSize;
        pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
        DataView dv = (DataView)AccessDataSource1.Select(DataSourceSelectArguments.Empty);
        pds.DataSource = dv;
        Repeater1.DataSource = pds;
        Repeater1.DataBind();
    }
    
    protected void AspNetPager1_PageChanged(object src, EventArgs e)
    {
        bindData();
    }

    protected void AccessDataSource1_Selected(object sender, SqlDataSourceStatusEventArgs e)
    {
        AspNetPager1.RecordCount = e.AffectedRows;
    }
}
