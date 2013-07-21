using System;
using System.Collections.Generic;
/// <summary>
/// Business object layer
/// Webdiyer(www.webdiyer.com) 2006-11-27
/// </summary>
public class Order
{
    #region private fields

    private int orderID;
    private DateTime orderDate;
    private string customerID;
    private string companyName;
    private string employeeName;


    #endregion

    #region public constructors

    public Order(){ }

    public Order(int orderID,DateTime orderDate,string customerID,string companyName,string employeeName){
        this.orderID=orderID;
        this.orderDate=orderDate;
        this.customerID=customerID;
        this.companyName=companyName;
        this.employeeName=employeeName;
    }

    #endregion

    #region public properties

    public int OrderID
    {
        get
        {
            return orderID;
        }
        set
        {
            orderID = value;
        }
    }

    public DateTime OrderDate
    {
        get
        {
            return orderDate;
        }
        set
        {
            orderDate = value;
        }
    }


    public string CompanyName
    {
        get { return companyName; }
        set { companyName = value; }
    }

    public string EmployeeName
    {
        get { return employeeName; }
        set { employeeName = value; }
    }

    public string CustomerID
    {
        get { return customerID; }
        set { customerID = value; }
    }

    #endregion

}
