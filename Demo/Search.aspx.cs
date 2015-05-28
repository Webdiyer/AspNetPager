using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Search_Default : Page
{
    const string vsKey = "searchCriteria"; //ViewState key
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            searchOrders(string.Empty);
        }
    }

    protected void btn_search_Click(object sender, EventArgs e)
    {
        AspNetPager1.CurrentPageIndex = 1;
        btn_all.Enabled = true;
        string s = " where orderid " + DropDownList1.SelectedValue + tb_orderid.Text;
        ViewState[vsKey] = s;
        searchOrders(s);
    }

    void searchOrders(string sWhere)
    {
        SqlDataSource1.SelectCommand = "select O.orderid,O.orderdate,O.customerid,C.CompanyName,E.FirstName+' '+E.LastName as EmployeeName from orders O left outer join Customers C on O.CustomerID=C.CustomerID left outer join Employees E on O.EmployeeID=E.EmployeeID " + sWhere + " order by orderid desc";
        DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        AspNetPager1.RecordCount = dv.Count;

        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = dv;
        pds.AllowPaging = true;
        pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
        pds.PageSize = AspNetPager1.PageSize;
        Repeater1.DataSource = pds;
        Repeater1.DataBind();
    }

    protected void AspNetPager1_PageChanged(object src, EventArgs e)
    {
        searchOrders((string)ViewState[vsKey]);
    }
    protected void btn_all_Click(object sender, EventArgs e)
    {
        ViewState[vsKey] = null;
        btn_all.Enabled = false;
        AspNetPager1.CurrentPageIndex = 1;
        searchOrders(null);
    }
}
