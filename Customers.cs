using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;

namespace Project_OOP_Trio_Rawr
{
    public class Customers
    {
        private string name;
        private Image picture;
        private string type;
        private Items item;

        public Customers(string name, Image picture, string type)
        {
            Name = name;
            Picture = picture;
            Type = type;
        }

        public string Name { get => name; set => name = value; }
        public Image Picture { get => picture; set => picture = value; }
        public string Type { get => type; set => type = value; }
        public Items Item { get => item; set => item = value; }

        public string Display()
        {
            if (type.ToLower() == "man")
            {
                return $"helo my name is {this.Name}";
            }
            else if (type.ToLower() == "woman")
            {
                return $"";
            }
            else
            {
                return $"morning..";
            }
            
        }

        //public Items AddOrder()
        //{

        //}
    }
}