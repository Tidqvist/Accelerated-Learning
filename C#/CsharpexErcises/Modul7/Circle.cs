using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7
{
    class Circle : Shape
    {

        public decimal Radius { get; }

        public Circle()
        {
            Console.WriteLine("Enter radius of circle");
            string inputRadius = Program.getInput("^\\d+,?\\d?$");

            Radius = decimal.Parse(inputRadius);
        }
        public override string ToString()
        {
            return $"I am a {this.GetType().Name} with Radius {Radius}";
        }

    }
}
