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
        // database connection
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataReader dr;

        // Leap Listener 
        private Controller controller;
        private LeapEventListener listener;
        delegate void LeapEventDelegate(string EventName);

        int[] indexList;


        Frame currentFrame;// saves current frame

        bool UpdateEnable = true; // enable lables update of distances



        private int i = 0; // listener interval

        public SignsDatabase()
        {
            InitializeComponent();
            this.Focus();

            InitializeList(); // initialize samples from database to a list

            //initializing listener and controller
            controller = new Controller();
            listener = new LeapEventListener(this);
            controller.AddListener(listener);
           
        }

        private void InitializeList()
        {
            // ============================================== Database ==============================================
            connection = new OleDbConnection();
            command = new OleDbCommand();

            SamplesList.Items.Clear();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SVMdataset.accdb";
            command.Connection = connection;

            string q = "select * from DataSet";
            command.CommandText = q;
            connection.Open();
            dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            indexList = new int[dt.Rows.Count];

            dr = command.ExecuteReader();


            int i = 0;
            if (dr.HasRows) // run over the table and put it on the list
            {
                while (dr.Read())
                {
                    indexList[i] = Convert.ToInt32(dr[0]);
                    SamplesList.Items.Add(dr[1].ToString()+"-" + dr[0].ToString());
                    i++;
                }
            }
            connection.Close();
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
                        this.connectHandler();
                        break;
                    case "onDisconnect":                       
                        //this.connectHandler();
                        break;
                    case "onFrame":
                        if (!this.Disposing)
                            frameListener(this.controller.Frame()); // sends frame to the handler
                        break;
                }
            }
            else
            {
                this.BeginInvoke(new LeapEventDelegate(LeapEventNotification), new object[] { EventName });
            }
        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }

        private void SamplesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEnable = false;

            string str = SamplesList.SelectedItem.ToString();
            int ind = SamplesList.SelectedIndex;
            string q = "select * from DataSet";
            command.CommandText = q;
            connection.Open();
            dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);          

            foreach (DataRow row in dt.Rows)
            {
                if (ind==0)
                {
                    OutputData1.Text = row[2].ToString();
                    OutputData2.Text = row[3].ToString();
                    OutputData3.Text = row[4].ToString();
                    OutputData4.Text = row[5].ToString();
                    OutputData5.Text = row[6].ToString();
                }

                ind--;
            }

            
                 
            connection.Close();
            

        }

        private void CaptureFrameBtn_Click(object sender, EventArgs e)
        {

            saveSapmle(currentFrame);

        }

        private void saveSapmle(Frame fr)
        {
            double[] distances = new double[5];

            if (fr == null || LeapEventListener.isZeros(distances) == true)
            {
                MessageBox.Show("The frame is null.\n Try reconnecting the Leap device", "Application Error",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                distances = LeapEventListener.getDistances(fr);
                
                if (MessageBox.Show("Do you want to save the sample as "+LettersCombo.Text+"?", "Signs DataSet",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question)
             == DialogResult.Yes)
                {
                    saveSampleToDB(LettersCombo.Text, distances[0], distances[1], distances[2], distances[3], distances[4]);
                }
            }
        }

        private void saveSampleToDB(string lettter,double thumb, double index, double middle, double ring, double pinky)
        {
            
            command = new OleDbCommand();
           // connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\SVMdataset.accdb";
            command.Connection = connection;
            connection.Open();
            

            try
            {
                command.CommandType = CommandType.Text;
               // string q = "INSERT INTO DataSet(Letter, thumb, index, middle,ring,pinky) VALUES("+ lettter + ","+ thumb +","+ index + "," + middle + "," + ring + "," + pinky + ")";
                string q = "INSERT INTO DataSet([Letter],[thumb],[index],[middle],[ring],[pinky]) VALUES(@letter,@thumb,@index,@middle,@ring,@pinky)";
                command.CommandText = q;
                command.Parameters.AddWithValue("@letter", lettter);
                command.Parameters.AddWithValue("@thumb", thumb);
                command.Parameters.AddWithValue("@index", index);
                command.Parameters.AddWithValue("@middle", middle);
                command.Parameters.AddWithValue("@ring", ring);
                command.Parameters.AddWithValue("@pinky", pinky);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
            connection.Close();

            InitializeList();

        }
      

        private void SignsDatabase_Load(object sender, EventArgs e)
        {

        }

        

        void frameListener(Frame frame) // the frame handler
        {
            
            currentFrame = frame;
            double[] distances = new double[5];
       


            i++;

            if (i == Constants.framesInterval)
            {
                if (UpdateEnable == true)
                {

                    distances = LeapEventListener.getDistances(frame);

                    OutputData1.Text = distances[0].ToString();
                    OutputData2.Text = distances[1].ToString();
                    OutputData3.Text = distances[2].ToString();
                    OutputData4.Text = distances[3].ToString();
                    OutputData5.Text = distances[4].ToString();
                }

                i = 0;


            }

        }

        private void informationBox_Enter(object sender, EventArgs e)
        {

        }

        private void StartListeningBtn_Click(object sender, EventArgs e)
        {
            UpdateEnable = true;
            
                  

        }

        private void OutputData1_Click(object sender, EventArgs e)
        {

        }

        private void SignsDatabase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                 saveSapmle(currentFrame);
        }

        private void CaptureFrameBtn_Click(object sender, KeyEventArgs e)
        {

        }

        private void DeleteSampleBtn_Click(object sender, EventArgs e)
        {
            int idx = SamplesList.SelectedIndex;

            command = new OleDbCommand();
            // connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\SVMdataset.accdb";
            command.Connection = connection;
            connection.Open();


            try
            {
                command.CommandType = CommandType.Text;
                // string q = "INSERT INTO DataSet(Letter, thumb, index, middle,ring,pinky) VALUES("+ lettter + ","+ thumb +","+ index + "," + middle + "," + ring + "," + pinky + ")";
                string q = "Delete from DataSet where indexer = "+indexList[idx];
                command.CommandText = q;
                
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            connection.Close();

            InitializeList();



        }
    }
}
