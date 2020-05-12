using LiteDB;
using RestaurantSystemCore.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantSystemCore
{
    public static class FoodManager
    {
        private static LiteDatabase db = DBProvider.GetDatabase();
        private static ILiteCollection<Food> colFood = db.GetCollection<Food>("foods");
        
        public static Category[] GetCategories()
        {
            // Loop through each foods to find all categories and the amount of foods in the categories

            SortedDictionary<string, Category> dict = new SortedDictionary<string, Category>();
            
            Food[] foods = GetFoods();            

            foreach(Food f in foods)
            {
                foreach(string cat in f.Categories)
                {
                    if (dict.ContainsKey(cat))
                    {
                        dict[cat].Amount += 1;
                    }
                    else
                    {
                        dict[cat] = new Category() { Name = cat, Amount = 1 };
                    }
                }
            }

            return dict.Values.ToArray();

        }

        public static void UpdateOrSaveFood(Food f)
        {
            
            colFood.Upsert(f);
        }

        public static void DeleteFood(Food f)
        {
            colFood.Delete(f.Id);
        }

        public static Food[] GetFoods(string category = "")
        {
            if(category.Length == 0)
            {   
                return colFood.FindAll().ToArray();
            }
            else
            {
                return colFood.Find(x => x.Categories.Contains(category)).ToArray();
            }
        }

        public static bool EditCategory(string oldName, string newName)
        {

            Category[] cats = GetCategories();

            foreach(Category c in cats)
            {
                if (c.Name == newName) return false;
            }


            Food[] foods = colFood.FindAll().ToArray();

            foreach(Food f in foods)
            {
                for(int i = 0; i < f.Categories.Length; ++i)
                {
                    if (f.Categories[i] == oldName) f.Categories[i] = newName;
                }
                colFood.Update(f);
            }

            return true;
        }
    }
}
