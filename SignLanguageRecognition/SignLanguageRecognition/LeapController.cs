using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Threading;
using Leap;

namespace SignLanguageRecognition
{
    class LeapController : LeapController.ILeapEventDelegate
    {
        
        private Controller controller;
        private LeapEventListener listener;
        delegate void LeapEventDelegate(string EventName);
        Form myForm;
        LeapControllerInterface myInterface;

        public LeapController(Form form, LeapControllerInterface myInt)
        {
            myForm = form;
            myInterface = myInt;



            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
            controller.AddListener(listener);
        }

        public void LeapEventNotification(string EventName)
        {
            if (!myForm.InvokeRequired)
            {
                switch (EventName)
                {
                    case "onInit":
                        Debug.WriteLine("Init");
                        break;
                    case "onConnect":
                        myInterface.onConnect();                     
                        this.connectHandler();
                        break;
                    case "onDisconnect":
                        myInterface.onDisconnect();
                        //this.connectHandler();
                        break;
                    case "onFrame":
                        if (!myForm.Disposing)
                            myInterface.frameListener(this.controller.Frame());
                        break;
                }
            }
            else
            {
                myForm.BeginInvoke(new LeapEventDelegate(LeapEventNotification), new object[] { EventName });
            }
        }

        void connectHandler()
        {
            this.controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            this.controller.Config.SetFloat("Gesture.Circle.MinRadius", 40.0f);
            this.controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
           
        }

        void newFrameHandler(Frame frame)
        {
            //The following are Label controls added in design view for the form
            // this.label1.Text = frame.Id.ToString();
            // this.label2.Text = frame.Timestamp.ToString();
            // this.label3.Text = frame.CurrentFramesPerSecond.ToString();
            // this.label4.Text = frame.IsValid.ToString();

        }


        public interface ILeapEventDelegate
        {
            void LeapEventNotification(string EventName);
        }

        public class LeapEventListener : Listener
        {
            ILeapEventDelegate eventDelegate;

            public LeapEventListener(ILeapEventDelegate delegateObject)
            {
                this.eventDelegate = delegateObject;
            }
            public override void OnInit(Controller controller)
            {
                this.eventDelegate.LeapEventNotification("onInit");
            }
            public override void OnConnect(Controller controller)
            {
                this.eventDelegate.LeapEventNotification("onConnect");
            }
            public override void OnFrame(Controller controller)
            {
                this.eventDelegate.LeapEventNotification("onFrame");
            }
            public override void OnExit(Controller controller)
            {
                this.eventDelegate.LeapEventNotification("onExit");
            }
            public override void OnDisconnect(Controller controller)
            {
                this.eventDelegate.LeapEventNotification("onDisconnect");
            }
        }
    }
}
