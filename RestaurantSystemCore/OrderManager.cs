using LiteDB;
using RestaurantSystemCore.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RestaurantSystemCore
{
    public static class OrderManager
    {
        private static LiteDatabase db = DBProvider.GetDatabase();
        private static ILiteCollection<Order> colOrder = db.GetCollection<Order>("orders");

        public static Order[] GetAllOrders()
        {
            return colOrder.FindAll().ToArray();
        }

        public static void AddOrder(Order o)
        {
            colOrder.Insert(o);
        }

        public static void UpdateOrder(Order o)
        {
            colOrder.Update(o);
        }
    }
}
