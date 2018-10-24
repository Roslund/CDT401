using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepositoryComponent;

namespace AdminComponent
{
    public partial class AdminMainPage : Form
    {
        public AdminController AdminController;

        public AdminMainPage()
        {
            this.AdminController = new AdminController();
            InitializeComponent();
            ViewButton.Enabled = false;
            EditButton.Enabled = false;
            RemoveButton.Enabled = false;
            InitialisationListViewComponent();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                int idSelected = int.Parse(ListViewComponents.SelectedItems[0].Text);
                AddPage AddPage = new AddPage(1, this.AdminController.ComponentsList.Find(delegate (RepositoryComponent.Component a) { return a.Id == idSelected; }), this.AdminController);
                AddPage.Show();
            }
            catch
            {
                ViewButton.Enabled = false;
                EditButton.Enabled = false;
                RemoveButton.Enabled = false;
            }
            
  
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                int idSelected = int.Parse(ListViewComponents.SelectedItems[0].Text);
                AddPage AddPage = new AddPage(2, AdminController.ComponentsList.Find(delegate (RepositoryComponent.Component a) { return a.Id == idSelected; }), this.AdminController);
                AddPage.Show();
            }
            catch
            {
                MessageBox.Show("Select a component before ...", "Confirm", MessageBoxButtons.OK);
                ViewButton.Enabled = false;
                EditButton.Enabled = false;
                RemoveButton.Enabled = false;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
                try
                {
                    if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int idSelected = int.Parse(ListViewComponents.SelectedItems[0].Text);
                        AdminController.removeCompoennt(idSelected);
                    }
                }
                catch
                {
                    MessageBox.Show("Select a component before ...", "Confirm", MessageBoxButtons.OK);
                    ViewButton.Enabled = false;
                    EditButton.Enabled = false;
                    RemoveButton.Enabled = false;
                }
        }

        private void InitializePage()
        {

        }

        private void AdminMainPage_Load(object sender, EventArgs e)
        {

        }

        //ADD BUTTON---------------------
        private void button1_Click(object sender, EventArgs e)
        {
            AddPage AddPage = new AddPage(this.AdminController);
            AddPage.Show();
        }

        private void ListViewComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewButton.Enabled = true;
            EditButton.Enabled = true;
            RemoveButton.Enabled = true;

            if(ListViewComponents.SelectedIndices.Count == 0)
            {

            }
        }

        private void InitialisationListViewComponent()
        {
            ListViewComponents.Items.Clear();

            foreach (RepositoryComponent.Component component in AdminController.ComponentsList)
            {
                string[] newItemString = new string[4];
                ListViewItem newItem;
                newItemString[0] = component.Id.ToString();
                newItemString[1] = component.Title;
                newItemString[2] = component.FileName;
                newItemString[3] = component.ShortDescription;
                newItem = new ListViewItem(newItemString);
                ListViewComponents.Items.Add(newItem);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            InitialisationListViewComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (RepositoryComponent.Component component in AdminController.ComponentsList)
            {
                if (component.Title == searchTextBox.Text)
                {
                    MessageBox.Show("I found it ! ID = " + component.Id, "Confirm", MessageBoxButtons.OK);
                    found = true;
                }
            }
            if(found == false)
                MessageBox.Show("Not found ... ", "Confirm", MessageBoxButtons.OK);
        }
    }
}
