using System;

namespace CShar.Session3
{
    public class Delegates
    {
        public delegate void PrintMessage(string msg);

        public void ShowInfo(string s)
        {
            Console.WriteLine("Show info: "+s);
        }
    }
}