using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Decorator;
using Design_Patterns_Assignment.Decorator.Decorators;
using System;

namespace Design_Patterns_Assignment
{
    internal class Decoratorr
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Decorator Pattern
            Console.WriteLine("Decorator");
            Console.WriteLine("Please enter the text.");
            IDecorator textInput = new SimpleText(Console.ReadLine());
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("1) Bold");
            Console.WriteLine("2) Deleted");
            Console.WriteLine("3) Emphasized");
            Console.WriteLine("4) Important");
            Console.WriteLine("5) Inserted");
            Console.WriteLine("6) Italic");
            Console.WriteLine("7) Marked");
            Console.WriteLine("8) Smaller");
            Console.WriteLine("9) SubScript");
            Console.WriteLine("0) SuperScript");
            Console.WriteLine("¨*********************************");
            Console.WriteLine("Choose the tags you want to add");
            Console.WriteLine("**********************************");
            Console.WriteLine("Press A to see your result");
            Console.WriteLine("**********************************");

            while (true)
            {
                var userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case 'A' or 'a':
                        Console.Clear();
                        Console.WriteLine($"The result is: {textInput.GetDecor()}");
                        break;
                    case '1':
                        Console.WriteLine("Bold has been added");
                        textInput = new Bold(textInput);
                        break;
                    case '2':
                        Console.WriteLine("Deleted has been added");
                        textInput = new Deleted(textInput);
                        break;
                    case '3':
                        Console.WriteLine("Emphasized has been added");
                        textInput = new Emphasized(textInput);
                        break;
                    case '4':
                        Console.WriteLine("Important has been added");
                        textInput = new Important(textInput);
                        break;
                    case '5':
                        Console.WriteLine("Inserted has been added");
                        textInput = new Inserted(textInput);
                        break;
                    case '6':
                        Console.WriteLine("Italic has been added");
                        textInput = new Italic(textInput);
                        break;
                    case '7':
                        Console.WriteLine("Marked has been added");
                        textInput = new Marked(textInput);
                        break;
                    case '8':
                        Console.WriteLine("Smaller has been added");
                        textInput = new Smaller(textInput);
                        break;
                    case '9':
                        Console.WriteLine("SubScript has been added");
                        textInput = new SubScript(textInput);
                        break;
                    case '0':
                        Console.WriteLine("Superman has been added");
                        textInput = new SuperScript(textInput);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}