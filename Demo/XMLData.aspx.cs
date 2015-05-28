using System;
using System.Data;
using System.Web.Caching;
using System.Web.UI;

public partial class XMLData_Default : Page
{
            const string cacheKey = "ordersTable";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable tbl = loadFromXMLOrCache();
            AspNetPager1.RecordCount = tbl.Rows.Count;
        }
    }

    DataTable loadFromXMLOrCache()
    {
        DataTable tbl = (DataTable)Cache[cacheKey];
        if (null == tbl)
        {
            string xmlFile = Server.MapPath("~/app_data/orders.xml");
            tbl = new DataTable();
                tbl.ReadXml(xmlFile);
            CacheDependency dep = new CacheDependency(xmlFile);
            Cache.Insert(cacheKey, tbl, dep);
        }
        return tbl;
    }

    protected void AspNetPager1_PageChanged(object src, EventArgs e)
    {
        DataTable tbl= loadFromXMLOrCache();
        if (tbl != null && tbl.Rows.Count > 0)
        {
            DataView dv = tbl.DefaultView;
            dv.Sort = "orderid desc";
            DataTable srcTbl = tbl.Clone();
            for (int i = AspNetPager1.StartRecordIndex; i <= AspNetPager1.EndRecordIndex; i++)
            {
                srcTbl.ImportRow(dv[i-1].Row);
            }
            Repeater1.DataSource = srcTbl;
            Repeater1.DataBind();
        }
    }
}
