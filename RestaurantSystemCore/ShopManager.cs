using LiteDB;
using RestaurantSystemCore.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Drawing;

namespace RestaurantSystemCore
{
    public static class ShopManager
    {
        private static LiteDatabase db = DBProvider.GetDatabase();
        private static ILiteCollection<ShopConfig> col_configs = db.GetCollection<ShopConfig>("configs");



        public static string ShopName
        {
            get {
                
                var result = col_configs.FindOne(x => x.Key == "name");
                
                if (result == null) return "";
                return result.Value;
            }
            set {
                var result = col_configs.FindOne(x => x.Key == "name");
                if(result == null)
                {
                    col_configs.Insert(new ShopConfig
                    {
                        Key = "name",
                        Value = value
                    });
                }
                else
                {
                    result.Value = value;
                    col_configs.Update(result);
                }
            }
        }

        public static string ShopLogo
        {
            get
            {

                var result = col_configs.FindOne(x => x.Key == "logo");

                if (result == null) return "";
                return result.Value;
            }
            set
            {
                var result = col_configs.FindOne(x => x.Key == "logo");
                if (result == null)
                {
                    col_configs.Insert(new ShopConfig
                    {
                        Key = "logo",
                        Value = value
                    });
                }
                else
                {
                    result.Value = value;
                    col_configs.Update(result);
                }
            }
        }
        public static string ShopPassword
        {
            get
            {

                var result = col_configs.FindOne(x => x.Key == "password");

                if (result == null) return "";
                return result.Value;
            }
            set
            {
                var result = col_configs.FindOne(x => x.Key == "password");
                if (result == null)
                {
                    col_configs.Insert(new ShopConfig
                    {
                        Key = "password",
                        Value = value
                    });
                }
                else
                {
                    result.Value = value;
                    col_configs.Update(result);
                }
            }
        }


        public static string ShopAnnouncement
        {
            get
            {

                var result = col_configs.FindOne(x => x.Key == "announcement");

                if (result == null) return "";
                return result.Value;
            }
            set
            {
                var result = col_configs.FindOne(x => x.Key == "announcement");
                if (result == null)
                {
                    col_configs.Insert(new ShopConfig
                    {
                        Key = "announcement",
                        Value = value
                    });
                }
                else
                {
                    result.Value = value;
                    col_configs.Update(result);
                }
            }
        }

        public static string ShopThemeName
        {
            get
            {

                var result = col_configs.FindOne(x => x.Key == "theme");

                if (result == null) return "";
                return result.Value;
            }
            set
            {
                var result = col_configs.FindOne(x => x.Key == "theme");
                if (result == null)
                {
                    col_configs.Insert(new ShopConfig
                    {
                        Key = "theme",
                        Value = value
                    });
                }
                else
                {
                    result.Value = value;
                    col_configs.Update(result);
                }
            }
        }


        public static string ShiftCb1StartTime
        {
            get
            {

                var result = col_configs.FindOne(x => x.Key == "starttime");

                if (result == null) return "";
                return result.Value;
            }
            set
            {
                var result = col_configs.FindOne(x => x.Key == "starttime");
                if (result == null)
                {
                    col_configs.Insert(new ShopConfig
                    {
                        Key = "starttime",
                        Value = value
                    });
                }
                else
                {
                    result.Value = value;
                    col_configs.Update(result);
                }
            }
        }

        public static string ShiftCb2Interval
        {
            get
            {

                var result = col_configs.FindOne(x => x.Key == "interval");

                if (result == null) return "";
                return result.Value;
            }
            set
            {
                var result = col_configs.FindOne(x => x.Key == "interval");
                if (result == null)
                {
                    col_configs.Insert(new ShopConfig
                    {
                        Key = "interval",
                        Value = value
                    });
                }
                else
                {
                    result.Value = value;
                    col_configs.Update(result);
                }
            }
        }

        public static string ShiftCb3Amount
        {
            get
            {

                var result = col_configs.FindOne(x => x.Key == "amount");

                if (result == null) return "";
                return result.Value;
            }
            set
            {
                var result = col_configs.FindOne(x => x.Key == "amount");
                if (result == null)
                {
                    col_configs.Insert(new ShopConfig
                    {
                        Key = "amount",
                        Value = value
                    });
                }
                else
                {
                    result.Value = value;
                    col_configs.Update(result);
                }
            }
        }

    }
}