using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

/// <summary>
/// Data access layer
/// Webdiyer(www.webdiyer.com) 2006-11-27
/// </summary>
public sealed class OrderData
{
	private OrderData(){}

    /// <summary>
    /// 获取要分页的记录总数
    /// </summary>
    /// <returns></returns>
    public static int GetOrderCount()
    {
        return (int)SqlHelper.ExecuteScalar(CommandType.StoredProcedure, "P_GetOrderNumber");
    }

    /// <summary>
    /// 获取要分页的当前页的记录
    /// </summary>
    /// <param name="startIndex">当前页要显示的记录的起始索引</param>
    /// <param name="endIndex">当前页要显示的记录的结束索引</param>
    /// <returns>当前页要显示的记录集合</returns>
    public static List<Order> GetPagedOrders(int startIndex, int endIndex)
    {
        SqlDataReader reader = SqlHelper.ExecuteReader(CommandType.StoredProcedure, System.Configuration.ConfigurationManager.AppSettings["pagedSPName"],
            new SqlParameter("@startIndex", startIndex),
            new SqlParameter("@endIndex", endIndex));
        List<Order> orders = new List<Order>();
        while (reader.Read())
        {
            orders.Add(new Order(reader.GetInt32(0),reader.GetDateTime(1),reader.GetString(2),reader.GetString(3),reader.GetString(4)));
        }
        reader.Close();
        return orders;
    }
}
