using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Ajax_default : System.Web.UI.Page
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
