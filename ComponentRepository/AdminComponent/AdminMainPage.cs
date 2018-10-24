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
        private AdminController AdminController;

        public AdminMainPage()
        {          
            this.AdminController = new AdminController();
            InitializeComponent();
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
            int idSelected = int.Parse(ListViewComponents.SelectedItems[0].Text);
            Console.WriteLine(idSelected);
            AddPage AddPage = new AddPage(1, AdminController.ComponentsList.Find(delegate(RepositoryComponent.Component a){ return a.Id == idSelected; }));
            AddPage.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void InitializePage()
        {

        }

        private void AdminMainPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPage AddPage = new AddPage();
            AddPage.Show();
        }

        private void ListViewComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World");
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
    }
}
