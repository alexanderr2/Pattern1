using Design_Patterns_Assignment.Strategy.Message;
using System;

namespace Design_Patterns_Assignment
{
    internal class Strategyy
    {
        internal static void Run()
        {
            MessageHandler messageHandler = new();
            Sms sms = new();
            SendEmail sendEmail = new ();
            FacebookMessage facebookMessage = new ();

            while (true)
            {



                // Refactor this code so that it uses the strategy Pattern
                Console.WriteLine("Strategy");
                var message = "Very good to meet you";

                Console.WriteLine("P) Send message with the type you want");
                Console.WriteLine("E) Email");
                Console.WriteLine("S) Sms");
                Console.WriteLine("F) Facebook message");

                char userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case 'P' or 'p':
                        Console.Clear();
                        messageHandler.Send(message);
                        break;
                    case 'E' or 'e':
                        Console.Clear();
                        Console.WriteLine("sending by Email");
                        messageHandler.Message = sendEmail;
                        Console.ReadLine();
                        break;
                    case 'S' or 's':
                        Console.Clear();
                        Console.WriteLine("sending by SMS");
                        messageHandler.Message = sms;
                        Console.ReadLine();
                        break;
                    case 'F' or 'f':
                        Console.Clear();
                        Console.WriteLine("sending by Facebook messenger");
                        messageHandler.Message = facebookMessage;
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}