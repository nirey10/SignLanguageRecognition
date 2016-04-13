using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Leap;

namespace SignLanguageRecognition
{
    public partial class MainMenu : Form,LeapControllerInterface
    {
        public MainMenu()
        {
            InitializeComponent();
            LeapControllerInterface myInterface = this;

            LeapController myLeap = new LeapController(this, myInterface);
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

         void LeapControllerInterface.onConnect()
        {
            ConnectionLable.Text = "Leap Connected";
            ConnectionLable.ForeColor = Color.Green;

        }

         void LeapControllerInterface.onDisconnect()
        {
            ConnectionLable.Text = "Leap is Not Connected";
            ConnectionLable.ForeColor = Color.Crimson;
        }

         void LeapControllerInterface.frameListener(Frame frame)
        {
            throw new NotImplementedException();
        }
    }
}
