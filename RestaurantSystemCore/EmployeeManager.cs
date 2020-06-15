using LiteDB;
using RestaurantSystemCore.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantSystemCore
{
    public static class EmployeeManager
    {
        private static LiteDatabase db = DBProvider.GetDatabase();
        public static ILiteCollection<Employee> colEmployee = db.GetCollection<Employee>("employees");
        
        public static Category[] GetCategories()
        {
            // Loop through each foods to find all categories and the amount of foods in the categories

            SortedDictionary<string, Category> dict = new SortedDictionary<string, Category>();
            
            Employee[] employees = GetEmployees();            

            foreach(Employee f in employees)
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

        public static void UpdateOrSaveEmployee(Employee e)
        {

            colEmployee.Upsert(e);
        }

        public static void DeleteEmployee(Employee e)
        {
            colEmployee.Delete(e.Id);  
        }

        public static Employee[] GetEmployees(string category = "")
        {
            if(category.Length == 0)
            {   
                return colEmployee.FindAll().ToArray();
            }
            else
            {
                return colEmployee.Find(x => x.Categories.Contains(category)).ToArray();
            }
        }

        public static bool EditCategory(string oldName, string newName)
        {

            Category[] cats = GetCategories();

            foreach(Category c in cats)
            {
                if (c.Name == newName) return false;
            }


            Employee[] employees = colEmployee.FindAll().ToArray();

            foreach(Employee e in employees)
            {
                for(int i = 0; i < e.Categories.Length; ++i)
                {
                    if (e.Categories[i] == oldName) e.Categories[i] = newName;
                }
                colEmployee.Update(e);
            }

            return true;
        }

        
    }
}
