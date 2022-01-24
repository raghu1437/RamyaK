using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
   public class OldPhone : IBasicPhone
    {
        public void MakeVoiceCall()
        {
            Console.WriteLine("Making Voice Calls");
        }
        public void SendMessages()
        {
            Console.WriteLine("Sending Messages");
        }
    }
}
