using Design_Patterns_Assignment;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Decoratorr.Run();
            //Repositoryy.Run();
            //Strategyy.Run();
            //Observerr.Run();

            //// Run Autofac Configure
            //var container = AFConfig.Configure();

            //// Create an instance of IApplication since we are not using a constructor here
            //using (var scope = container.BeginLifetimeScope())
            //{
            //    var app = scope.Resolve<IApplication>();
            //    app.Run();
            //}
        }     
    }
}
