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
using Accord.Statistics.Kernels;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using System.Data.OleDb;

namespace SignLanguageRecognition
{
    

    public partial class MainMenu : Form, ILeapEventDelegate
    {

        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataReader dr;

        private Controller controller;
        private LeapEventListener listener;
        delegate void LeapEventDelegate(string EventName);

        public MainMenu()
        {
            InitializeComponent();

            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
            controller.AddListener(listener);


            //  myLeap = new LeapController(this, myInterface);

            /*
            connection = new OleDbConnection();
            command =new OleDbCommand();


            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\SVMdataset.accdb";
            command.Connection = connection;

            string q = "select * from DataSet";
            command.CommandText = q;
            connection.Open();
            dr = command.ExecuteReader();

            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    ConnectionLable.Text = dr[1].ToString();
                }
            }
            connection.Close();
            
    */


        }

        void connectHandler()
        {
            this.controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            this.controller.Config.SetFloat("Gesture.Circle.MinRadius", 40.0f);
            this.controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);

        }
        public void LeapEventNotification(string EventName)
        {
            if (!this.InvokeRequired)
            {
                switch (EventName)
                {
                    case "onInit":
                        Debug.WriteLine("Init");
                        break;
                    case "onConnect":
                        onConnect();
                        this.connectHandler();
                        break;
                    case "onDisconnect":
                        onDisconnect();
                        //this.connectHandler();
                        break;
                    case "onFrame":
                       // if (!this.Disposing)
                          //  this.frameListener(this.controller.Frame());
                        break;
                }
            }
            else
            {
                this.BeginInvoke(new LeapEventDelegate(LeapEventNotification), new object[] { EventName });
            }
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

         void onConnect()
        {
            ConnectionLable.Text = "Leap Connected";
            ConnectionLable.ForeColor = Color.Green;

        }

         void onDisconnect()
        {
            ConnectionLable.Text = "Leap is Not Connected";
            ConnectionLable.ForeColor = Color.Crimson;
        }

    }
}
