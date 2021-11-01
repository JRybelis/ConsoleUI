using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfParties = new List<string>();
            int totalGuests = 0;
            string moreGuestsComing = "";
            
            do
            {
                string leadGuestName = GetInfoFromConsole("What is the full name of the main guest of this party?"); 
                
                listOfParties.Add(leadGuestName);
                totalGuests += GetPartySize();
                
                moreGuestsComing = GetInfoFromConsole("Will there be more guests coming to register (yes/no)?");
            } while (moreGuestsComing.ToLower() == "yes");

            Console.WriteLine();
            Console.WriteLine("Guest parties attending tonight:");
            foreach (string name in listOfParties)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            Console.WriteLine($"Total guests: {totalGuests}");
            
            Console.ReadLine();
        }

        private static string GetInfoFromConsole(string message)
        {
            Console.WriteLine(message);
                string output = Console.ReadLine();
            return output;
        }

        private static int GetPartySize()
        {
            bool isValidNumber = false;
            int output = 0;
            do
            {
                string partySizeText = GetInfoFromConsole("How many people are in the party?");
                isValidNumber = int.TryParse(partySizeText, out output);
            } while (isValidNumber == false);

            return output;
        }
    }
}