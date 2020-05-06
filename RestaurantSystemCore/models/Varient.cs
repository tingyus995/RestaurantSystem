using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantSystemCore.models
{
    public class Varient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int delta { get; set; }
        public byte[] image { get; set; }
    }
}
