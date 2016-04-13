using Leap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignLanguageRecognition
{
    public interface LeapControllerInterface
    {
        void onConnect();
        void onDisconnect();
        void frameListener(Frame frame);

    }
}
