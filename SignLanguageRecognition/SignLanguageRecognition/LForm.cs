using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leap;

namespace SignLanguageRecognition
{
    public partial class LForm : Form, LeapControllerInterface
    {
        

        public LForm() : base()
        {
          
        }

        public virtual void frameListener(Frame frame)
        {
            
        }

        public virtual void onConnect()
        {
            
        }

        public virtual void onDisconnect()
        {
            
        }
    }
}
