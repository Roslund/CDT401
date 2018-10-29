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
    public partial class AddPage : Form
    {
        RepositoryComponent.Component componentChoosen;
        AdminController adminControllerPage;
        private int modeActuel;

        public AddPage()
        {
            InitializeComponent();
            modeActuel = 0;
            componentChoosen = new RepositoryComponent.Component();
        }

        public AddPage(AdminController adminController)
        {
            InitializeComponent();
            modeActuel = 0;
            componentChoosen = new RepositoryComponent.Component();
            adminControllerPage = adminController;
        }

        public AddPage(int mode, RepositoryComponent.Component component, AdminController adminController)
        {
            InitializeComponent();
            componentChoosen = component;
            modeActuel = mode;

            switch (mode)
            {
                case 1:
                    selectButton.Enabled = false;
                    ValidateButton.Enabled = false;

                    TitleTextBox.Enabled = false;
                    TitleTextBox.Text = componentChoosen.Title;

                    ShortTextBox.Enabled = false;
                    ShortTextBox.Text = componentChoosen.ShortDescription;

                    LongTextBox.Enabled = false;
                    LongTextBox.Text = componentChoosen.LongDescription;

                    break;

                case 2:

                    adminControllerPage = adminController;

                    selectButton.Enabled = false;

                    TitleTextBox.Text = componentChoosen.Title;
                    Console.WriteLine(componentChoosen.Title);
                    ShortTextBox.Text = componentChoosen.ShortDescription;
                    LongTextBox.Text = componentChoosen.LongDescription;

                    break;
            }
        }

        //Validation button Click
        private void button2_Click(object sender, EventArgs e)
        {
            if (Verification())
            {
                componentChoosen.LongDescription = LongTextBox.Text;
                componentChoosen.ShortDescription = ShortTextBox.Text;
                componentChoosen.Title = TitleTextBox.Text;

                if (modeActuel == 2)
                {
                    adminControllerPage.editComponent(componentChoosen);
                    this.Close();
                }
                else
                {
                    Console.WriteLine("test 1");
                    var filePath = openFileDialog1.FileName;
                    byte[] bytes = System.IO.File.ReadAllBytes(filePath); // convert en byte ....
                    Console.WriteLine("test 2");
                    componentChoosen.Content = bytes;
                    componentChoosen.FileName = filePath.Split('\\').Last();
                    Console.WriteLine("test 3");
                    adminControllerPage.addComponent(componentChoosen);
                    Console.WriteLine("test 4");
                    this.Close();  
                }
            }else
                MessageBox.Show("Contents too shorts or too longs ...", "OK", MessageBoxButtons.OK);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Verification()
        {
            if ((LongTextBox.Text.Length > 2 && LongTextBox.Text.Length < 45)&&(ShortTextBox.Text.Length > 2 && ShortTextBox.Text.Length < 45) &&(TitleTextBox.Text.Length > 2 && TitleTextBox.Text.Length < 45))
                return true;
            else
                return false;      
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string sFileName = openFileDialog1.FileName;
                FileSelectedLabel.Text = sFileName;
            }
        }
    }
}
