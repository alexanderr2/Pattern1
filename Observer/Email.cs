using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment
{
    internal class Emails
    {
        public List<Observerr> Observers { get; set; }

        public Emails()
        {
            Observers = new();
        }

        public void RegisterObserver(Observerr observer)
        {
            Observers.Add(observer);
        }
        public void UnregisterObserver(Observerr observer)
        {
            Observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update("Hi and welcome friends!");
            }

        }
            internal string Check()
            {
                var evenMinute = DateTime.Now.Minute % 2;
                if (evenMinute == 0)
                {
                    Notify();
                }
                return null;
            }
    }
}