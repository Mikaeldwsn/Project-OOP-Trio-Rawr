using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_OOP_Trio_Rawr
{
    public class Players
    {
        private string name;
        private int bestIncome;

        public Players(string name, int bestIncome)
        {
            Name = name;
            BestIncome = bestIncome;
        }

        public string Name { get => name; set => name = value; }
        public int BestIncome { get => bestIncome; set => bestIncome = value; }

        public string Display()
        {
            return "";
        }

    }
}