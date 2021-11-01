using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        private static List<string> listOfParties = new List<string>();
        private static int _totalGuests = 0;
        static void Main(string[] args)
        {
            LoadGuests();
            
            DisplayGuests();
            
            DisplayGuestCount();
            
            Console.ReadLine();
        }

        private static void DisplayGuestCount()
        {
            Console.WriteLine();
            Console.WriteLine($"Total guests: { _totalGuests }");
        }
        private static void DisplayGuests()
        {
            Console.WriteLine();
            Console.WriteLine("Guest parties attending tonight:");
            foreach (string name in listOfParties)
            {
                Console.WriteLine(name);
            }
        }

        private static void LoadGuests()
        {
            string moreGuestsComing = "";
            do
            {
                string leadGuestName = GetInfoFromConsole("What is the full name of the main guest of this party?"); 
                
                listOfParties.Add(leadGuestName);
                _totalGuests += GetPartySize();
                
                moreGuestsComing = GetInfoFromConsole("Will there be more guests coming to register (yes/no)?");
            } while (moreGuestsComing.ToLower() == "yes");
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
                string partySizeText = GetInfoFromConsole("How many people are in their party?");
                isValidNumber = int.TryParse(partySizeText, out output);
            } while (isValidNumber == false);

            return output;
        }
    }
}