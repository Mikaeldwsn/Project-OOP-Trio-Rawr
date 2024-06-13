using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Project_OOP_Trio_Rawr
{
    public class Foods : Items
    {
        private List<Ingridients> ingridients;

        public List<Ingridients> Ingridients { get => ingridients; set => ingridients = value; }

        public Foods(string name, Image picture, int price):base(name, picture, price)
        {
            this.Ingridients = new List<Ingridients>();
        }

        public override string Display()
        {
            return "";
        }
    }
}