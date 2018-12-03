using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7
{
    class Triangle : Shape   
    {
        public decimal Base { get; }
        public decimal Height { get; }

        public Triangle()
        {
            Console.WriteLine("Enter base of triangle");
            string inputBase = Program.getInput("^\\d+,?\\d?$");

            Base = decimal.Parse(inputBase);

            Console.WriteLine("Enter height of triangle");
            string inputHeight = Program.getInput("^\\d+,?\\d?$");

            Height = decimal.Parse(inputHeight);

        }

        public override string ToString()
        {
    
            return $"I am a {this.GetType().Name} with height {Height} and Base {Base}";
        }

    }
}
