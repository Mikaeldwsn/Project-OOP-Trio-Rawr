﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        Random random = new Random();

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
            CreateCustomer();
            SetStallDisplay();
        }

        private void SetStallDisplay()
        {
            CreateFoods();
        }
        private void CreateFoods()
        {
            //Burger
            items = new Foods("Burger", Properties.Resources.burger, 50000);
            listofitems.Add(items);

            ((Foods)items).AddIngredient("plate", Properties.Resources.plate);
            ((Foods)items).AddIngredient("bottompan", Properties.Resources.bottompan);
            ((Foods)items).AddIngredient("patty", Properties.Resources.patty);
            ((Foods)items).AddIngredient("letuce", Properties.Resources.lettuce);
            ((Foods)items).AddIngredient("toppan", Properties.Resources.toppan);

            pictureFood0.Tag = ((Foods)items).Ingredients[0].Name;
            pictureFood1.Tag = ((Foods)items).Ingredients[1].Name;
            pictureFood2.Tag = ((Foods)items).Ingredients[2].Name;
            pictureFood3.Tag = ((Foods)items).Ingredients[3].Name;
            pictureFood4.Tag = ((Foods)items).Ingredients[4].Name;

            pictureFood0.Image = ((Foods)items).Ingredients[0].Picture;
            pictureFood1.Image = ((Foods)items).Ingredients[1].Picture;
            pictureFood2.Image = ((Foods)items).Ingredients[2].Picture;
            pictureFood3.Image = ((Foods)items).Ingredients[3].Picture;
            pictureFood4.Image = ((Foods)items).Ingredients[4].Picture;

            pictureFood0.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFood1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFood2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFood3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFood4.SizeMode = PictureBoxSizeMode.StretchImage;

            //Salad
            items = new Foods("Healthy Salad", Properties.Resources.salad, 25000);
            listofitems.Add(items);
            ((Foods)items).AddIngredient("plate", Properties.Resources.plate);
            ((Foods)items).AddIngredient("letuce", Properties.Resources.lettuce);
            ((Foods)items).AddIngredient("mayo", Properties.Resources.mayo);

            pictureFood5.Tag = ((Foods)items).Ingredients[2].Name;

            pictureFood5.Image = ((Foods)items).Ingredients[2].Picture;

            pictureFood5.SizeMode = PictureBoxSizeMode.StretchImage;

            items = new Foods("Ice Cream", Properties.Resources.icecream, 8000);
            listofitems.Add(items);

            ((Foods)items).AddIngredient("ice", Properties.Resources.ice);
            ((Foods)items).AddIngredient("cone", Properties.Resources.cone);

            pictureFood6.Tag = ((Foods)items).Ingredients[0].Name;
            pictureFood7.Tag = ((Foods)items).Ingredients[1].Name;

            pictureFood6.Image = ((Foods)items).Ingredients[0].Picture;
            pictureFood7.Image = ((Foods)items).Ingredients[1].Picture;

            pictureFood6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFood7.SizeMode = PictureBoxSizeMode.StretchImage;

            items = new Foods("Large Coffe Cold", Properties.Resources.coffee_L_cold, 23000);

            ((Foods)items).AddIngredient("Large Coffe Cold", Properties.Resources.coffee_L_cold);
            coffeL1.Tag = ((Foods)items).Ingredients[0].Name;
            coffeL1.Image = ((Foods)items).Ingredients[0].Picture;

            items = new Foods("Large Coffe Hot", Properties.Resources.coffee_L_hot, 23000);

            ((Foods)items).AddIngredient("Large Coffe Hot", Properties.Resources.coffee_L_hot);
            coffeL2.Tag = ((Foods)items).Ingredients[0].Name;
            coffeL2.Image = ((Foods)items).Ingredients[0].Picture;

            items = new Foods("Medium Coffe Cold", Properties.Resources.coffee_M_cold, 15000);

            ((Foods)items).AddIngredient("Medium Coffe Cold", Properties.Resources.coffee_M_cold);
            coffeM1.Tag = ((Foods)items).Ingredients[0].Name;
            coffeM1.Image = ((Foods)items).Ingredients[0].Picture;

            items = new Foods("Medium Coffe Hot", Properties.Resources.coffee_M_hot, 15000);

            ((Foods)items).AddIngredient("Medium Coffe Cold", Properties.Resources.coffee_M_hot);
            coffeM2.Tag = ((Foods)items).Ingredients[0].Name;
            coffeM2.Image = ((Foods)items).Ingredients[0].Picture;

            items = new Foods("Smaal Coffe Cold", Properties.Resources.coffee_S_cold, 8000);

            ((Foods)items).AddIngredient("Small Coffe Cold", Properties.Resources.coffee_S_cold);
            coffeS1.Tag = ((Foods)items).Ingredients[0].Name;
            coffeS1.Image = ((Foods)items).Ingredients[0].Picture;

            items = new Foods("Small Coffe Hot", Properties.Resources.coffee_S_hot, 8000);

            ((Foods)items).AddIngredient("Small Coffe Hot", Properties.Resources.coffee_S_hot);
            coffeS2.Tag = ((Foods)items).Ingredients[0].Name;
            coffeS2.Image = ((Foods)items).Ingredients[0].Picture;

            coffeL1.SizeMode = PictureBoxSizeMode.StretchImage;
            coffeL2.SizeMode = PictureBoxSizeMode.StretchImage;
            coffeM1.SizeMode = PictureBoxSizeMode.StretchImage;
            coffeM2.SizeMode = PictureBoxSizeMode.StretchImage;
            coffeS1.SizeMode = PictureBoxSizeMode.StretchImage;
            coffeS2.SizeMode = PictureBoxSizeMode.StretchImage;

            Merchandise merch1 = new Merchandise(random.Next(1, 5), "Plushie", Properties.Resources.plushie, 30000);
            listofitems.Add(merch1);

            labelMerc1.Text = merch1.Stock.ToString();
            merchandise1.Tag = Properties.Resources.plushie;
            merchandise1.Image = Properties.Resources.plushie;

            merchandise1.SizeMode = PictureBoxSizeMode.StretchImage;

            Merchandise merch2 = new Merchandise(random.Next(1, 5), "Plushie", Properties.Resources.tumbler, 20000);
            listofitems.Add(merch2);

            labelMerc2.Text = merch2.Stock.ToString();
            merchandise2.Tag = Properties.Resources.tumbler;
            merchandise2.Image = Properties.Resources.tumbler;

            merchandise2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Refresh();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void CreateCustomer()
        {
            
            int randomNum = random.Next(0, 2);

            if (randomNum == 0)
            {
                customers = new Customers("David", Properties.Resources.david, "man");
            } 
            if (randomNum == 1)
            {
                customers = new Customers("Anna", Properties.Resources.anna, "woman");
            }
            if (randomNum == 2)
            {
                customers = new Customers("Bryan", Properties.Resources.bryan, "kid");
            }

            pictureBoxCustomer.Image = customers.Picture;
            pictureBoxCustomer.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxCustomer.BackColor = Color.Transparent;
        }

        public void CreateOrder()
        {

        }
    }

   
}