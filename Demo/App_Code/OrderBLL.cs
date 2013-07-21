using System;
using System.Collections.Generic;

/// <summary>
/// Business logic layer for Order
/// Webdiyer(en.webdiyer.com) 2006-11-27
/// </summary>
public sealed class OrderInfo
{
    private OrderInfo() { }

    /// <summary>
    /// get records of the current page
    /// </summary>
    /// <param name="startIndex">start record index</param>
    /// <param name="pageSize">page size</param>
    /// <returns></returns>
    public static List<Order> GetPagedOrders(int startIndex, int pageSize)
    {
        int endIndex = startIndex + pageSize - 1; 
        return OrderData.GetPagedOrders(startIndex, endIndex);
    }

    /// <summary>
    /// get the total record count
    /// </summary>
    /// <returns></returns>
    public static int GetOrderCount()
    {
        return OrderData.GetOrderCount();
    }
}
