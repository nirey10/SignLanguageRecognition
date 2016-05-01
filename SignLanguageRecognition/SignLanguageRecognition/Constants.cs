using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignLanguageRecognition
{
    class Constants
    {
        public static int framesInterval = 5; //checks every framesInterval frames
        public static int continuousTimerInterval = 10 ; 
        public static int velocityThreshold = 170; //velocity threshold for continuous data instance . 
        public static int positionStallThreshold = 300; //value in millisecond . 
    }
}
