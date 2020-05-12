using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantSystemCore.models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int SelectedVarientIndex { get; set; }
        public int Amount { get; set; }
        public int BasePrice { get; set; }
        public byte[] Image { get; set; }
        public string[] Categories { get; set; }
        public Varient[] Varients { get; set; }

        public Food clone()
        {
            return new Food(){
                Id = this.Id,
                Name = this.Name,
                SelectedVarientIndex = this.SelectedVarientIndex,
                Amount = this.Amount,
                BasePrice = this.BasePrice,
                Image = this.Image,
                Categories = this.Categories, // we won't change it in its clone, so shallow copy is enough
                Varients = this.Varients // we won't change it in its clone, so shallow copy is enough
            };
        }
    }
}