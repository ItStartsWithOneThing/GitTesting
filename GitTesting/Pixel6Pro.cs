using System;
using System.Collections.Generic;
using System.Text;

namespace GitTesting
{
    public class Pixel6Pro
    {
        public string IMEI { get; set; }

        public void Call(int number)
        {
            Console.WriteLine("Calling...");
        }

        public void GetWifi(int password)
        {
            Console.WriteLine("Connecting...");
        }

        public void ReceiveCall(string name)
        {
            Console.WriteLine("Receiving...");
        }
    }
}
