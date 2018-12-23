using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_List
{
    class Screen
    {
        public static void ShowScreen()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("-----------Contacts-----------");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1 - Add a New Contract");
            Console.WriteLine("2 - Show Contacts");
            Console.WriteLine("3 - Delete Contacts");
            Console.WriteLine("4 - Exit");
            Console.WriteLine("------------------------------");
            Console.Write("Your Choice: ");
        }

        public static void CreateAContact()
        {
            Console.WriteLine("Instert The Dates of Contact: ");
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Number: ");
            int Number = int.Parse(Console.ReadLine());
            Console.Write("ID (example: 1): ");
            int ID = int.Parse(Console.ReadLine());
            Person P = new Person(ID, Name, Number);
            Program.person.Add(P);
        }

        public static void DeleteAContact()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("You Really want Delete yours Contacts? ");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("2 - No");
            Console.WriteLine("---------------------------------------");
            Console.Write("Your Choise: ");
            int N = int.Parse(Console.ReadLine());
            if (N == 1)
            {
                Console.WriteLine("-------------");
                Console.WriteLine("Your Contacts");
                Console.WriteLine("-------------");
                var Amount = 0;
                foreach (var Person in Program.person)
                {
                    Amount++;
                    Console.WriteLine(Amount + "º " + Person);
                }
                Console.Write("Type the Contact That Will be Deleted (example: ID: 1): ");
                int M = int.Parse(Console.ReadLine());
                Program.person.FindIndex(x => x.ID == M);
                Program.person.RemoveAt(M);
            }
        }

        public static void ShowContacts()
        {
            Console.WriteLine("-------------");
            Console.WriteLine("Your Contacts");
            Console.WriteLine("-------------");
            var Amount = 0;
            foreach (var Person in Program.person)
            {
                Amount++;
                Console.WriteLine(Amount + "º " + Person);
            }
        }
    }
}
