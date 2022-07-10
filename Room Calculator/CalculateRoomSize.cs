using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Calculator
{
    internal class CalculateRoomSize
    {
        public static double RoomSize(double roomLength,double roomWidth, double roomHeight)
        {
            double area = roomWidth * roomLength;
            double perimeter = (roomWidth + roomLength) * 2;
            double volume = roomLength * roomWidth * roomHeight;
            double surfaceArea = ((roomWidth * roomLength) * 2) + ((roomWidth * roomHeight) * 2) + ((roomLength * roomHeight) * 2);

            Console.WriteLine($"\nThe area of the room is {area}");
            Console.WriteLine($"The perimeter of the room is {perimeter}");
            Console.WriteLine($"The volume of the room is {volume}");
            Console.WriteLine($"The surface area of the room is {surfaceArea}");


            return area;
        }
    }
}
