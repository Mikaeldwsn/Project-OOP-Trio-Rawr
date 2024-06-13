using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Project_OOP_Trio_Rawr
{
    public class Foods : Items
    {
        private List<Ingredients> ingredients;

        public List<Ingredients> Ingredients { get => ingredients; set => ingredients = value; }

        public Foods(string name, Image picture, int price):base(name, picture, price)
        {
            this.Ingredients = new List<Ingredients>();
        }

        public override string Display()
        {
            return "";
        }

        public void AddIngredient()
        {

        }
    }
}