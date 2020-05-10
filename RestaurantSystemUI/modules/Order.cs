﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystemCore;
using RestaurantSystemCore.models;
using FontAwesome.Sharp;
using RestaurantSystemUI.modules;
using RestaurantSystemUI.controls;
using System.Drawing.Text;

namespace RestaurantSystemUI
{
    public partial class Order : UserControl
    {

        private const string ALL_CATEGORIES = "全部分類";

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            loadCategories();
        }

        private void loadCategories()
        {
            fpCategories.Controls.Clear();
            fpnLeftTitle.Controls.Clear();

            ThemedLabel lbTitle = new ThemedLabel()
            {
                Text = "請選擇食物分類"
            };

            fpnLeftTitle.Controls.Add(lbTitle);



            CategoryItem allCats = new CategoryItem()
            {
                Category = new Category()
                {
                    Name = ALL_CATEGORIES,
                    Amount = -1
                },
                Editable = false
            };

            allCats.CategoryItemClicked += (object _s, EventArgs _e) =>
            {   
                showFoods();
            };
            fpCategories.Controls.Add(allCats);





            Category[] cats = FoodManager.GetCategories();

            foreach (var c in cats)
            {
                CategoryItem item = new CategoryItem() { Category = c };
                item.CategoryItemClicked += (object _s, EventArgs _e) =>
                {

                    CategoryItem i = _s as CategoryItem;
                    showFoods(i.Category.Name);
                };

                fpCategories.Controls.Add(item);

            }
        }

        private void showFoods(string cat = "")
        {


            fpCategories.Controls.Clear();
            fpnLeftTitle.Controls.Clear();

            ThemedLabel lbTitle = new ThemedLabel()
            {
                Text = "請選擇食物"
            };

           



            IconButton ibtnBack = new IconButton()
            {
                IconChar = IconChar.ArrowLeft,
                Text = "",
                FlatStyle = FlatStyle.Flat,
                IconColor = Color.White               
                
            };

            ibtnBack.FlatAppearance.BorderColor = Color.White;           
            

            ibtnBack.Click += (object _sender, EventArgs _e) =>
            {
                loadCategories();
            };
            
            fpnLeftTitle.Controls.Add(ibtnBack);
            fpnLeftTitle.Controls.Add(lbTitle);

            

            foreach(Food f in FoodManager.GetFoods(cat))
            {
                
                FoodItem item = new FoodItem()
                {
                    Food = f
                };
                
                fpCategories.Controls.Add(item);

                item.FoodSelected += (object __s, FoodSelectedEventArgs __e) => {

                    FoodItem i = __s as FoodItem;
                    
                    orderPreview1.AddFood(i.Food.clone());
                };
            }          

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
