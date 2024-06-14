using System;
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
            CreateFoods();
        }

        private void CreateFoods()
        {
            items = new Foods("burger", Properties.Resources.burger, 50000);
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

            pictureFood0.Image = ((Foods)items).Ingredients[0].Picture;
            pictureFood1.Image = ((Foods)items).Ingredients[1].Picture;
            pictureFood2.Image = ((Foods)items).Ingredients[2].Picture;
            pictureFood3.Image = ((Foods)items).Ingredients[4].Picture;

            pictureFood0.Visible = true;
            ((Foods)items).AddIngredient("mayo", Properties.Resources.mayo);
        }

       
    }
}
