﻿using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels;
using Leap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignLanguageRecognition
{
    public partial class SingleInstanceTranslate : Form, ILeapEventDelegate
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataReader dr;

        // Leap Listener 
        private Controller controller;
        private LeapEventListener listener;
        delegate void LeapEventDelegate(string EventName);


        int numOfClasses = 0; // saves the number of calsses/letters
        double[][] inputs;
        // Output for each of the inputs
        int[] outputs;

        Frame currentFrame;
        private int i = 0; // listener interval


        public SingleInstanceTranslate()
        {
            InitializeComponent();

            InitializeSVM();

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
                        this.connectHandler();
                        break;
                    case "onDisconnect":
                        //this.connectHandler();
                        break;
                    case "onFrame":
                        if (!this.Disposing)
                            this.frameListener(this.controller.Frame()); // sends frame to the handler
                        break;
                }
            }
            else
            {
                this.BeginInvoke(new LeapEventDelegate(LeapEventNotification), new object[] { EventName });
            }
        }
        void frameListener(Frame frame) // the frame handler
        {           
            currentFrame = frame;

            double[] distances = new double[5];


            i++;
            if (i == Constants.framesInterval)
            {
              

                distances = LeapEventListener.getDistances(frame);
                OutputData1.Text = distances[0].ToString();
                OutputData2.Text = distances[1].ToString();
                OutputData3.Text = distances[2].ToString();
                OutputData4.Text = distances[3].ToString();
                OutputData5.Text = distances[4].ToString();

                i = 0;

            }

        }

        private void InitializeSVM()
        {
            // ============================================== Database ==============================================
            connection = new OleDbConnection();
            command = new OleDbCommand();
            double thumb, index, middle, ring, pinky;

            int svmClass = 0;                 

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SVMdataset.accdb";
            command.Connection = connection;

            string q = "select * from DataSet";
            command.CommandText = q;
            connection.Open();
            dr = command.ExecuteReader();
            int k = 0;
            DataTable dt = new DataTable();
            dt.Load(dr);
            outputs = new int[dt.Rows.Count];
            inputs = new double[dt.Rows.Count][];
            dr = command.ExecuteReader();

            if (dr.HasRows) // run over the table and put it on the list
            {
                while (dr.Read())
                {
                    char c = Convert.ToChar(dr[1]);
                    

                    svmClass = Char2SvmClass.char2class(c);//static method that converts the char to a class ;

                    thumb = Convert.ToDouble(dr[2]);
                    index = Convert.ToDouble(dr[3]);
                    middle = Convert.ToDouble(dr[4]);
                    ring = Convert.ToDouble(dr[5]);
                    pinky = Convert.ToDouble(dr[6]);

                    inputs[k] = new double[] { thumb, index, middle, ring, pinky };
                    outputs[k] = svmClass;


                    k++;
                }
            }
            connection.Close();




            //get from DB the number of classes
            command.Connection = connection;
            q = "select Distinct DataSet.Letter from DataSet";
            command.CommandText = q;
            connection.Open();
            dr = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            numOfClasses = dt.Rows.Count ; 
            connection.Close();



        }


        private void SingleInstanceTranslate_Load(object sender, EventArgs e)
        {

        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }

        private void TranslateBtn_Click(object sender, EventArgs e)
        {

            double[] distances = new double[5];
            distances = LeapEventListener.getDistances(currentFrame);

            if (LeapEventListener.isZeros(distances) == true)
            {
                MessageBox.Show("The frame is null.\n Try reconnecting the Leap device", "Application Error",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                // Create a new Linear kernel
                IKernel kernel = new Linear();

                // Create a new Multi-class Support Vector Machine with one input,
                //  using the linear kernel and for four disjoint classes.
                var machine = new MulticlassSupportVectorMachine(5, kernel, numOfClasses);

                // Create the Multi-class learning algorithm for the machine
                var teacher = new MulticlassSupportVectorLearning(machine, inputs, outputs);

                // Configure the learning algorithm to use SMO to train the
                //  underlying SVMs in each of the binary class subproblems.
                teacher.Algorithm = (svm, classInputs, classOutputs, i, j) =>
                     new SequentialMinimalOptimization(svm, classInputs, classOutputs);
                
                // Run the learning algorithm   
                double error = teacher.Run(); // output should be 0



                int decision = machine.Compute(distances); //svm AI 
                output.Text = output.Text + Char2SvmClass.class2svm(decision);
            }

        }

       

    }
}
