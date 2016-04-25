using Leap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignLanguageRecognition
{
   

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


        public static double[] getDistances(Frame frame)
        {
            
            double[] outDistance = new double[5];
            Finger thumbPos, indexPos, middlePos, ringPos, pinkyPos;
            double palmX, palmY, palmZ;


            thumbPos = frame.Hands[0].Fingers[0];
            indexPos = frame.Hands[0].Fingers[1];
            middlePos = frame.Hands[0].Fingers[2];
            ringPos = frame.Hands[0].Fingers[3];
            pinkyPos = frame.Hands[0].Fingers[4];

            palmX = frame.Hands[0].PalmPosition.x;
            palmY = frame.Hands[0].PalmPosition.y;
            palmZ = frame.Hands[0].PalmPosition.z;

            outDistance[0] = Math.Sqrt(Math.Pow((thumbPos.TipPosition.x - palmX), 2) + Math.Pow((thumbPos.TipPosition.y - palmY), 2) + Math.Pow((thumbPos.TipPosition.z - palmZ), 2));
            outDistance[1] = Math.Sqrt(Math.Pow((indexPos.TipPosition.x - palmX), 2) + Math.Pow((indexPos.TipPosition.y - palmY), 2) + Math.Pow((indexPos.TipPosition.z - palmZ), 2));
            outDistance[2] = Math.Sqrt(Math.Pow((middlePos.TipPosition.x - palmX), 2) + Math.Pow((middlePos.TipPosition.y - palmY), 2) + Math.Pow((middlePos.TipPosition.z - palmZ), 2));
            outDistance[3] = Math.Sqrt(Math.Pow((ringPos.TipPosition.x - palmX), 2) + Math.Pow((ringPos.TipPosition.y - palmY), 2) + Math.Pow((ringPos.TipPosition.z - palmZ), 2));
            outDistance[4] = Math.Sqrt(Math.Pow((pinkyPos.TipPosition.x - palmX), 2) + Math.Pow((pinkyPos.TipPosition.y - palmY), 2) + Math.Pow((pinkyPos.TipPosition.z - palmZ), 2));

            return outDistance;

        }
        public static bool isZeros(double[] arr)
        {
            for(int i=0;i<5;i++)
            {
                if (arr[i] == 0)
                    return true;
            }
            return false;
        }

        public static double[] getVelocity(Frame frame)
        {
            double[] outVelocity = new double[5];
            Finger thumbV, indexV, middleV, ringV, pinkyV;
            double palmX, palmY, palmZ;


            thumbV = frame.Hands[0].Fingers[0];
            indexV = frame.Hands[0].Fingers[1];
            middleV = frame.Hands[0].Fingers[2];
            ringV = frame.Hands[0].Fingers[3];
            pinkyV = frame.Hands[0].Fingers[4];


            palmX = frame.Hands[0].PalmVelocity.x;
            palmY = frame.Hands[0].PalmVelocity.y;
            palmZ = frame.Hands[0].PalmVelocity.z;


            outVelocity[0] = Math.Sqrt(Math.Pow(thumbV.TipVelocity.x,2)+Math.Pow(thumbV.TipVelocity.y,2)+Math.Pow(thumbV.TipVelocity.z,2));
            outVelocity[1] = Math.Sqrt(Math.Pow(indexV.TipVelocity.x, 2) + Math.Pow(indexV.TipVelocity.y, 2) + Math.Pow(indexV.TipVelocity.z, 2));
            outVelocity[2] = Math.Sqrt(Math.Pow(middleV.TipVelocity.x, 2) + Math.Pow(middleV.TipVelocity.y, 2) + Math.Pow(middleV.TipVelocity.z, 2));
            outVelocity[3] = Math.Sqrt(Math.Pow(ringV.TipVelocity.x, 2) + Math.Pow(ringV.TipVelocity.y, 2) + Math.Pow(ringV.TipVelocity.z, 2));
            outVelocity[4] = Math.Sqrt(Math.Pow(pinkyV.TipVelocity.x, 2) + Math.Pow(pinkyV.TipVelocity.y, 2) + Math.Pow(pinkyV.TipVelocity.z, 2));


            return outVelocity;

        }
    }
}
