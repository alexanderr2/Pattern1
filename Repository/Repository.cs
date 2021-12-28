using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Repository;
using System;

namespace Design_Patterns_Assignment
{
    internal class Repositoryy
    {
        internal static void Run()
        {
            DataRepository dbR = new();
            // Refactor this code so that it uses the Repository Pattern
            Console.WriteLine("Repository");
            var data = dbR.GetAllDataFromDB("Dataset A");
            var customer = dbR.GetAllDataFromDB("From Table Customer Where Name==Steve"); // this is a search
            var animal = dbR.GetAllDataFromDB("From Table Animal Where Owner==Steve"); // this is a search
            dbR.SaveTheData(data);
            dbR.SaveTheData(customer);
            dbR.SaveTheData(animal);
            Console.WriteLine();
        }
    }
}