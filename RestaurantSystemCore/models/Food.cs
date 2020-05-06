using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantSystemCore.models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int SelectedVarient { get; set; }
        public int BasePrice { get; set; }
        public byte[] image { get; set; }

        public Varient[] Varients;
    }
}
