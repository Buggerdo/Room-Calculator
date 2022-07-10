using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Calculator
{
    internal class GetRoomSize
    {
        public static void RoomSize(out double roomLength, out double roomWidth, out double roomHeight )
        {
            roomLength = userInput("length");
            roomWidth = userInput("width");
            roomHeight = userInput("height");
        }

        private static double userInput(string description)
        {
            bool isGood;
            double input = 0;
            do
            {
                Console.Write($"Please enter the {description} of the room : ");
                string stringInput = Console.ReadLine();
                try
                {
                    input = double.Parse(stringInput);
                    isGood = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    isGood = false;
                } 
            } while(!isGood);
            return input;
        }
    }
}
