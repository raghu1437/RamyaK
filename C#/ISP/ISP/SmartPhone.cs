using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ISP
{
    public class SmartPhone : Iphone, IBasicPhone
    {
        public void MakeVideoCalls()
        {
            Console.WriteLine("Making Video Calls");
        }
        public void MakeVoiceCall()
        {
            Console.WriteLine("Making Voice Calls");
        }
        public void SendMessages()
        {
            Console.WriteLine("Sending Messages");
        }
        public void TakePhotos()
        {
            Console.WriteLine("Taking Pictures");

        }
    }

}