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
        public AddPage()
        {
            InitializeComponent();
        }

        public AddPage(int mode, RepositoryComponent.Component component)
        {
            InitializeComponent();

            switch (mode)
            {
                case 1:
                    selectButton.Enabled = false;
                    ValidateButton.Enabled = false;

                    TitleTextBox.Enabled = false;
                    TitleTextBox.Text = component.Title;
                    Console.WriteLine(component.Title);

                    ShortTextBox.Enabled = false;
                    ShortTextBox.Text = component.ShortDescription;

                    LongTextBox.Enabled = false;
                    LongTextBox.Text = component.LongDescription;

                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
