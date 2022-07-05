using System;
using System.Collections.Generic;
using System.Text;

namespace GitTesting
{
    public class Xiaomi12Spro
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
    }
}
