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
using System.Diagnostics;
using System.Threading;
using Leap;
using Accord.Statistics.Kernels;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using System.Data.OleDb;

namespace SignLanguageRecognition
{
   
    public partial class SignsDatabase : Form, ILeapEventDelegate
    {

        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataReader dr;

        private Controller controller;
        private LeapEventListener listener;
        delegate void LeapEventDelegate(string EventName);


        public SignsDatabase()
        {
            InitializeComponent();
            InitializeList();

            //   LeapControllerInterface myInterface = this;
            //LeapController myLeap = new LeapController(this, myInterface);

            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
            controller.AddListener(listener);
            // ============================================== SVM ==============================================

            double[][] inputs =
                       {
    new double[] { 11,2,0},
    new double[] { 7,5,2},
    new double[] { 5,-2 ,-1 },
    new double[] { -2,-2 ,-2},
    new double[] { 0,-2 , 0},
    new double[] { 5,5 ,-1},
    //new double[] { 4,4 },
    //new double[] { -3,4 },
    //new double[] { -7,4 },
    //new double[] { -3,3 },
    //new double[] { -2,4 },
    //new double[] { -4,4 },
};

            // Output for each of the inputs
            int[] outputs = { 1, 1, 0, 0, 0, 1 };

            // Create a new Linear kernel
            IKernel kernel = new Linear();

            // Create a new Multi-class Support Vector Machine with one input,
            //  using the linear kernel and for four disjoint classes.
            var machine = new MulticlassSupportVectorMachine(3, kernel, 2);

            // Create the Multi-class learning algorithm for the machine
            var teacher = new MulticlassSupportVectorLearning(machine, inputs, outputs);

            // Configure the learning algorithm to use SMO to train the
            //  underlying SVMs in each of the binary class subproblems.
            teacher.Algorithm = (svm, classInputs, classOutputs, i, j) =>
                new SequentialMinimalOptimization(svm, classInputs, classOutputs);

            // Run the learning algorithm   
            double error = teacher.Run(); // output should be 0

            // Compute the decision output for one of the input vectors
            int decision = machine.Compute(new double[] { 2, 2, -1 }); // result should be 3

            Console.WriteLine("{0}", decision);


        }

        private void InitializeList()
        {
            // ============================================== Database ==============================================
            connection = new OleDbConnection();
            command = new OleDbCommand();


            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\SVMdataset.accdb";
            command.Connection = connection;

            string q = "select * from DataSet";
            command.CommandText = q;
            connection.Open();
            dr = command.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    SamplesList.Items.Add(dr[1].ToString());
                }
            }
        }
        private void SignsDatabase_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
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
                        this.connectHandler();
                        break;
                    case "onDisconnect":                       
                        //this.connectHandler();
                        break;
                    case "onFrame":
                        if (!this.Disposing)
                            this.frameListener(this.controller.Frame());
                        break;
                }
            }
            else
            {
                this.BeginInvoke(new LeapEventDelegate(LeapEventNotification), new object[] { EventName });
            }
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


        }

        private void SignsDatabase_Load(object sender, EventArgs e)
        {

        }

        int i = 0;

        void frameListener(Frame frame)
        {

            i++;
            if (i == 10)
            {

                OutputData1.Text = frame.Hands[0].PalmPosition.ToString();
                OutputData2.Text = frame.Hands[0].Fingers[0].TipPosition.ToString();
                OutputData3.Text = frame.Hands[0].Fingers[1].TipPosition.ToString();
                OutputData4.Text = frame.Hands[0].Fingers[2].TipPosition.ToString();
                OutputData5.Text = frame.Hands[0].Fingers[3].TipPosition.ToString();
                OutputData6.Text = frame.Hands[0].Fingers[4].TipPosition.ToString();
                i = 0;

            }

        }

        private void informationBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
