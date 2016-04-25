using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignLanguageRecognition
{
    public partial class CountinuousTranslate : Form
    {
        public CountinuousTranslate()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }

        private void CountinuousTranslate_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StartListeningBtn_Click(object sender, EventArgs e)
        {
            StatusGif.Enabled = true;
        }

        private void StopListeningBtn_Click(object sender, EventArgs e)
        {
            StatusGif.Enabled = false;
        }
    }
}
