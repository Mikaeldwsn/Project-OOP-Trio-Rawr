using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Project_OOP_Trio_Rawr
{
    public class Customers
    {
        private string name;
        private Image picture;
        private int type;

        public Customers(string name, Image picture, int type)
        {
            Name = name;
            Picture = picture;
            Type = type;
        }

        public string Name { get => name; set => name = value; }
        public Image Picture { get => picture; set => picture = value; }
        public int Type { get => type; set => type = value; }

        public string display()
        {
            return "";
        }

        public void AddOrder()
        {

        }
    }
}