using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SignLanguageRecognition
{
    public partial class SignsDatabase : Form
    {
        public SignsDatabase()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("Would you like to save the sample?", "Recorded Stopped", "Enter Sample Name", 10, 10);
            MessageBox.Show(x);

        }

        private void SignsDatabase_Load(object sender, EventArgs e)
        {

        }
    }
}
