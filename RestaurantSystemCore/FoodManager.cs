using LiteDB;
using RestaurantSystemCore.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantSystemCore
{
    public class FoodManager
    {
        LiteDatabase db;
        public FoodManager()
        {
            db = DBProvider.GetDatabase();            
        }

        public Category[] GetCategories()
        {
            var cat = db.GetCollection<Category>("categories");
            return cat.FindAll().ToArray();
        }

    }
}
