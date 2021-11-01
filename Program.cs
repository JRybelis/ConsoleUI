using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfParties = new List<string>();
            string moreGuestsComing = "";
            
            do
            {
                listOfParties.Add(GetInfoFromConsole("What is the full name of the main guest of this party?"));
                moreGuestsComing = GetInfoFromConsole("Will there be more guests coming to register (yes/no)?");
            } while (moreGuestsComing.ToLower() == "yes");
            
            Console.ReadLine();
        }

        private static string GetInfoFromConsole(string message)
        {
            Console.WriteLine(message);
                string output = Console.ReadLine();
            return output;
        }
    }
}