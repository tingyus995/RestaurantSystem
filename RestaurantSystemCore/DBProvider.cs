using LiteDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantSystemCore
{
    public static class DBProvider
    {        
        private static LiteDatabase DB = new LiteDatabase(@"Filename=data.db;Connection=Shared");

        public static LiteDatabase GetDatabase()
        {
            return DB;
        }
    }
}
