﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OOP_Trio_Rawr
{
    public partial class Form1 : Form
    {
        public List<Items> listofitems = new List<Items> ();

        int remainingcustomers;
        Items items;
        Customers customers;
        Players players;
        Time time;
        public List<Ingredients> listselectedFood = new List<Ingredients>();

        string filename = "game.dat";
        public Form1()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;

            //createplayer(); menambahkkan data player

            label3.Visible = true;
            label1.Visible = true;
           

            remainingcustomers = 5;
            label3.Text = "Remaining Customers: " + remainingcustomers.ToString();
           // time = new Time(0,0,0);
           //label1.Text= 
           
            //play sound
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
