using System;
using System.Collections.Generic;

namespace Contacts_List
{
    class Program
    {
        public static List<Person> person = new List<Person>();

        static void Main(string[] args)
        {
            Console.Clear();
            int option = 0;
            while(option == 0)
            {
                try
                {
                    Console.Clear();
                    Screen.ShowScreen();
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Screen.CreateAContact();
                            Console.WriteLine("Press 'Enter' To Continue.");
                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Fatal Error " + e.Message);
                                option = 0;
                            }
                            break;
                        case 2:
                            Screen.ShowContacts();
                            Console.WriteLine("Press 'Enter' To Continue.");
                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Fatal Error " + e.Message);
                                option = 0;
                            }
                            break;
                        case 3:
                            Screen.DeleteAContact();
                            Console.WriteLine("Press 'Enter' to continue.");
                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Fatal Error " + e.Message);
                                option = 0;
                            }
                            break;
                        case 4:
                            Console.Write("Ending...");
                            break;
                        default:
                            Console.WriteLine("Option not Found.");
                            option = 0;
                            Console.ReadLine();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected Error detected " + e.Message);
                    option = 0;
                    Console.ReadLine();
                }
            }
        }
    }
}
