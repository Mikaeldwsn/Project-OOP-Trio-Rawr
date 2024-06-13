using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Project_OOP_Trio_Rawr
{
    public class Merchandise : Items
    {
        private int stock;

        public Merchandise(int stock, string name, Image picture, int price): base(name , picture, price)
        {
            this.Stock = stock;
        }

        public int Stock { get => stock; set => stock = value; }

        public override string Display()
        {
            return "";
        }
        public bool CheckAvailibility()
        {
            return true;
        }
    }
}