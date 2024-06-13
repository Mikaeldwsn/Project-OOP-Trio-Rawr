using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Project_OOP_Trio_Rawr
{
    public class Beverages : Items
    {
        private bool isCold;
        private string size;

        public Beverages(bool isCold, string size, string name, Image picture, int price):base(name, picture, price)
        {
            this.IsCold = isCold;
            this.Size = size;
        }

        public bool IsCold { get => isCold; set => isCold = value; }
        public string Size { get => size; set => size = value; }

        public override string Display()
        {
            return "";
        }
    }
}