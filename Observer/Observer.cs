using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class Observerr
    {
        public void Update(string email)
        {
            Console.WriteLine(email);
        }
        internal static void Run()
        {
            // Refactor this code so that it uses the Observer Pattern
            Console.WriteLine("Observer");
            Observerr observer = new();
            Emails emails = new();

            while (true)
            {
                Console.WriteLine("Press 1 to update");
                Console.WriteLine("Press 2 to add or remove observer");

                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case '1':
                        emails.Check();
                        break;
                    case '2':
                        if (emails.Observers.Contains(observer))
                        {
                            emails.UnregisterObserver(observer);
                            Console.WriteLine("Observer removed");
                        }
                        else
                        {
                            emails.RegisterObserver(observer);
                            Console.WriteLine("Observer added");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
