using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_OOP_Trio_Rawr
{
    public class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }

        public int Hour { get => hour; set => hour = value; }
        public int Minute { get => minute; set => minute = value; }
        public int Second { get => second; set => second = value; }

        public void Convert()
        {
            throw new System.NotImplementedException();
        }
        public void Add()
        {

        }
    }
}