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
                customers = new Customers("");
            } 
            if (randomNum == 1)
            {

            }
            if (randomNum == 2)
            {

            }
        }

        public void CreateOrder()
        {

        }
    }

   
}