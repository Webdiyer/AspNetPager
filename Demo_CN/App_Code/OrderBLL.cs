using System;
using System.Collections.Generic;

/// <summary>
/// Business logic loyer for Order
/// Webdiyer(www.webdiyer.com) 2006-11-27
/// </summary>
public sealed class OrderInfo
{
    private OrderInfo() { }

    /// <summary>
    /// 获取要分页的当前页的记录
    /// </summary>
    /// <param name="startIndex">当前页要显示的记录的起始索引</param>
    /// <param name="pageSize">每页要显示的记录数</param>
    /// <returns>当前页要显示的记录集合</returns>
    public static List<Order> GetPagedOrders(int startIndex, int pageSize)
    {
        int endIndex = startIndex + pageSize - 1; //当前页要显示的记录的结束索引
        return OrderData.GetPagedOrders(startIndex, endIndex);
    }

    /// <summary>
    /// 获取要分页的记录总数，用于设置AspNetPager的RecordCount属性的值
    /// </summary>
    /// <returns></returns>
    public static int GetOrderCount()
    {
        return OrderData.GetOrderCount();
    }
}
