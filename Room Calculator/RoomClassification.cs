using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Calculator
{
    internal class RoomClassification
    {
        public static void RoomClassify(double area)
        {
            if(area < 250) Console.WriteLine("This is a small room.");
            else if(area < 650) Console.WriteLine("This is a medium room.");
            else Console.WriteLine("This is a large room.");
        }
    }
}
