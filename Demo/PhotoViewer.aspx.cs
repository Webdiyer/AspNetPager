using System;
using System.IO;

public partial class PhotoViewer_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string[] files = Directory.GetFiles(Server.MapPath("images/xian/"),"xian*.jpg");
            AspNetPager1.RecordCount = files.Length;
        }
    }

    void showPicture()
    {
        string[] pname = Directory.GetFiles(Server.MapPath("images/xian/"), "xian*.jpg");
        img1.ImageUrl = "images/xian/" + Path.GetFileName(pname[AspNetPager1.CurrentPageIndex-1]);
    }
    protected void AspNetPager1_PageChanged(object src, EventArgs e)
    {
        showPicture();
    }
}
