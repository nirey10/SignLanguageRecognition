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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void SignDatabaseBtn_Click(object sender, EventArgs e)
        {
            SignsDatabase database = new SignsDatabase();
            database.Show();
            this.Hide();
        }

        private void ContinuousTranslatingBtn_Click(object sender, EventArgs e)
        {
            CountinuousTranslate ContinuousRecognition = new CountinuousTranslate();
            ContinuousRecognition.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
