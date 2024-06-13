using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Project_OOP_Trio_Rawr
{
    public abstract class Items
    {
        private string name;
        private Image picture;
        private int price;

        protected Items(string name, Image picture, int price)
        {
            Name = name;
            Picture = picture;
            Price = price;
        }

        public string Name { get => name; set => name = value; }
        public Image Picture { get => picture; set => picture = value; }
        public int Price { get => price; set => price = value; }

        protected virtual string DisplayItems()
        {
            return "";
        }

        public abstract string Display();
    }
}