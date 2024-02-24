using System;

namespace CShar.Session2
{
    public class FPTAptechStudent : Student,IStudent
    {
        public override void Learn()
        {
            Console.WriteLine("Learning...");
        }

        public override void Play()
        {
            Console.WriteLine("Playing...");
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Sing()
        {
            throw new NotImplementedException();
        }

        public void PlayFootball()
        {
            throw new NotImplementedException();
        }
    }
}