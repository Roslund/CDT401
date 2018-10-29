using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace AdminComponent
{
    public partial class Menu : Form
    {
        //list of components
        public void getAllCompoennts(){}
        public void addComponent() { }
        public void editComponent() { }
        public void removeComponent() { }
        public int x;

        public void updateViewListComponent()
        {
            NewItemList(this.x);
            this.x++;
        }

        public Menu()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            updateViewListComponent();
        }
    }
}
