using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane[] planes = new Plane[4];
            SingleEnginePlane singleEnginePlane = new SingleEnginePlane();
            PaperPlane paperPlane = new PaperPlane();
            ToyPlane toyPlane = new ToyPlane();
            SeaPlane seaPlane = new SeaPlane();

            planes[0] = singleEnginePlane;
            planes[1] = paperPlane;
            planes[2] = toyPlane;
            planes[3] = seaPlane;

            foreach(Plane plane in planes)
            {
                plane.Display();
                plane.StartEngine();
                plane.Fly();
                plane.Land();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

