using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Project_OOP_Trio_Rawr
{
    public class Ingredients
    {
        private string name;
        private Image picture;

        public Ingredients(string name, Image picture)
        {
            Name = name;
            Picture = picture;
        }

        public string Name { get => name; set => name = value; }
        public Image Picture { get => picture; set => picture = value; }

        public string Display()
        {
            return "";
        }
    }
}