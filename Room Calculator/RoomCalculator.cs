using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Calculator
{
    internal class RoomCalculator
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!\n");
            GetRoomSize.RoomSize(out double roomLength, out double roomWidth, out double roomHeight);
            RoomClassification.RoomClassify(CalculateRoomSize.RoomSize(roomLength, roomWidth, roomHeight));
            Console.WriteLine("\nThank you for using the Room Detail Generator!");
        }
    }
}
