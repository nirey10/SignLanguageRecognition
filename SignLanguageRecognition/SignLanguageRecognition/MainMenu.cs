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

        // Leap Listener 
        private Controller controller;
        private LeapEventListener listener;
        delegate void LeapEventDelegate(string EventName);

        public MainMenu()
        {
            InitializeComponent();


            //initializing listener and controller
            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
            controller.AddListener(listener);
        }

        void connectHandler() // set leap gestures when connected
        {
            this.controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            this.controller.Config.SetFloat("Gesture.Circle.MinRadius", 40.0f);
            this.controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);

        }
        public void LeapEventNotification(string EventName) // event notification handler
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
        /// <summary>
        /// This method closes the form . 
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing)
                {
                    if (components != null)
                    {
                        components.Dispose();
                    }
                    this.controller.RemoveListener(this.listener);
                    this.controller.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
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

         void onConnect() // execute when connected
        {
            ConnectionLable.Text = "Leap Connected";
            ConnectionLable.ForeColor = Color.Green;

        }

         void onDisconnect() // execute when disconnected
        {
            ConnectionLable.Text = "Leap is Not Connected";
            ConnectionLable.ForeColor = Color.Crimson;
        }

        private void SingleInstancesTranslatingBtn_Click(object sender, EventArgs e)
        {
            SingleInstanceTranslate singleInstances = new SingleInstanceTranslate();

            singleInstances.Show();
           
            this.Hide();
        }
    }
}
