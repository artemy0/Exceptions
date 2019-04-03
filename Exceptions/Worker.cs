using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Worker
    {
        private static int Count = 0;

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string PositionHeld { get; private set; }
        public double Wage { get; private set; }

        public Worker()
        {
            Id = Count++;
        }
        public Worker(string name) : this()
        {
            Name = name;
        }
        public Worker(string name, string positionHeld) : this(name)
        {
            PositionHeld = positionHeld;
        }
        public Worker(string name, string positionHeld, int age) : this(name, positionHeld)
        {
            Age = age;
        }
        public Worker(string name, string positionHeld, int age, double wage) : this(name, positionHeld, age)
        {
            Wage = wage;
        }

        //Output all information
        public void PrintInfoInConsole()
        {
            PrintIdInConsole();
            PrintNameInConsole();
            PrintPositionHoldInConsole();
            PrintAgeInConsole();
            PrintWageInConsole();
        }

        //Output part of the information
        public void PrintIdInConsole()
        {
            Console.WriteLine($"Id: {Id}");
        }

        public void PrintNameInConsole()
        {
            if (!string.IsNullOrEmpty(Name))
                Console.WriteLine($"Name: {Name}");
            else
                throw new IncorrectPersonalInformationException(this, "There is no information about the worker."); //properties can be set only in constructors, and in accordance with the constructor, if the Name property is empty, then all other fields are empty
        }

        public void PrintPositionHoldInConsole()
        {
            if (!string.IsNullOrEmpty(PositionHeld))
                Console.WriteLine($"Position held: {PositionHeld}");
            else
                throw new IncorrectPersonalInformationException(this, "The worker can not hold position.");
        }

        public void PrintAgeInConsole()
        {
            if (Age != default(int))
            {
                if (Age < 0)
                    throw new IncorrectPersonalInformationException(this, "Age cannot be negative.");
                Console.WriteLine($"Age: {Age}");
            }
        }

        public void PrintWageInConsole()
        {
            if (Wage != default(double))
            {
                if (Wage < 0)
                    throw new IncorrectPersonalInformationException(this, "Wage cannot be negative.");
                Console.WriteLine($"Wage: {Wage}");
            }
        }
    }
}
