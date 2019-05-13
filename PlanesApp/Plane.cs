using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesApp
{
    class Plane
    {
        public virtual void Display()
        {
            Console.WriteLine("I am a plane");
        }

        public virtual void StartEngine()
        {
            Console.WriteLine("Engine Started!");
        }

        public virtual void Fly()
        {
            Console.WriteLine("Flying");
        }

        public virtual void Land()
        {
            Console.WriteLine("Landing");
        }
    }
}
