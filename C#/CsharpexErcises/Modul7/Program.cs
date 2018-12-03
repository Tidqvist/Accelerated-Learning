using MagnusHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Modul7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> listOfShapes = new List<Shape>();
            bool done = false;

            do
            {
                Regex menueChoises = new Regex("^[TRCDtrcd]$");
                string menueOption = Menue(menueChoises);

                switch (menueOption.ToUpper())
                {
                    case "T":
                        listOfShapes.Add(new Triangle());
                        break;
                    case "R":
                        listOfShapes.Add(new Rectangle());
                        break;
                    case "C":
                        listOfShapes.Add(new Circle());
                        break;
                    case "D":
                        done = true;
                        break;
                }

            } while (done == false);

            foreach (Shape shape in listOfShapes)
            {
                Console.WriteLine(shape);
            }

            List<string> typer = new List<string>();
            foreach (Shape shape in listOfShapes)
            {
                typer.Add(shape.GetType().Name);
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("You seleted ");

            if (listOfShapes.Count > 0)
            {
                string trianglar = $"{NumberToWords(typer.FindAll(typ => typ == "Triangle").Count)} triangle{(typer.FindAll(typ => typ == "Triangle").Count > 1 ? "s" : "")}";
                string rektanglar = $"{NumberToWords(typer.FindAll(typ => typ == "Rectangle").Count)} rektangle{(typer.FindAll(typ => typ == "Rectangle").Count > 1 ? "s" : "")}";
                string cirklar = $"{NumberToWords(typer.FindAll(typ => typ == "Circle").Count)} circle{(typer.FindAll(typ => typ == "Circle").Count > 1 ? "s" : "")}";

                List<string> messages = new List<string>();

                if (typer.FindAll(typ => typ == "Triangle").Count > 0)
                    messages.Add(trianglar);
                if (typer.FindAll(typ => typ == "Rectangle").Count > 0)
                    messages.Add(rektanglar);
                if (typer.FindAll(typ => typ == "Circle").Count > 0)
                    messages.Add(cirklar);

                if (messages.Count == 1)
                    sb.Append(messages[0]);
                else if (messages.Count == 2)
                    sb.Append(messages[0] + " and " + messages[1]);
                else
                    sb.Append($"{messages[0]}, {messages[1]} and {messages[2]}");
            }
            else
            {
                sb.Append("nothing");
            }

            //Console.WriteLine($"You selected {NumberToWords(t.Count)} triangles, {NumberToWords(r.Count)} rectangels, {NumberToWords(c.Count)}.");
            Console.WriteLine(sb);
            Console.ReadKey();

        }

        private static string Menue(Regex regexExpression)
        {
            Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or (D)one: ");

            Console.ForegroundColor = ConsoleColor.Green;
            string menueOption = Helpers.getString(regexExpression);
            Console.ResetColor();

            return menueOption;
        }

        internal static string getInput(string regexExpression)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();
            Console.ResetColor();
            if (!Regex.IsMatch(input.ToUpper(), regexExpression))
            {
                Console.WriteLine("Invalid input");
                return getInput(regexExpression);
            }
            return input;
        }
        //////////////////////////////////////////////////////
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
