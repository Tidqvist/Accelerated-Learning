using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7
{
    class Rectangle : Shape
    {
        public decimal Height { get; }
        public decimal Lenght { get; }

        public Rectangle()
        {
            Console.WriteLine("Enter Height of rectangle");
            string inputHeight = Program.getInput("^\\d+,?\\d?$");

            Height = decimal.Parse(inputHeight);

            Console.WriteLine("Enter Lenght of rectangle");
            string inputLenght = Program.getInput("^\\d+,?\\d?$");

            Lenght = decimal.Parse(inputLenght);
        }

        public override string ToString()
        {
            return $"I am a {this.GetType().Name} with height {Height} and length {Lenght}";
        }

    }
}
