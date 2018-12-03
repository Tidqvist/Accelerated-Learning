using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;
using MagnusHelpers;

namespace Modul4
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Uppgift1o2();
                Uppgift2();
            } while (Helpers.askIfExit() == false);
        }

        private static void Uppgift2()
        {
            char separator = getSeparator();
            bool showError = getErrors();
            string[] nameArray;
            do
            {
                Console.WriteLine("Ange namn separerade med mellanslag");
                string input = Console.ReadLine().ToUpper();
                nameArray = splitInput(input, separator);
            } while (validateArray(nameArray, showError) == false);

            prepareArrayForWriting(nameArray);
            Helpers.writeInColor(nameArray, ConsoleColor.Green);

        }

        private static bool validateArray(string[] nameArray, bool showError)
        {
            if (nameArray.Length == 0)
            {
                if (showError)
                    Helpers.writeInColor("Du måste ange ett värde", ConsoleColor.Red);
                return false;
            }
            else
            {
                foreach (string name in nameArray)
                {
                    if (!Regex.IsMatch(name.ToUpper(), "^.{2,9}$"))
                    {
                        if (showError)
                            Helpers.writeInColor("Alla namn måste vara mellan 2-9 bokstäver långa", ConsoleColor.Red);
                        return false;
                    }
                    else if (!Regex.IsMatch(name.ToUpper(), "^[A-Z^ÅÄÖ]+$"))
                    {
                        if (showError)
                            Helpers.writeInColor("Namn får endast innehålla bokstäver", ConsoleColor.Red);
                        return false;
                    }

                    //foreach (char c in name)
                    //{
                    //    if (char.IsLetter(c) == false)
                    //    {
                    //        if (showError)
                    //            Helpers.writeInColor("Namn får endast innehålla bokstäver", ConsoleColor.Red);
                    //        return false;
                    //    }

                    //}
                }
            }
            return true;
        }

        private static string[] splitInput(string input, char separator)
        {
            List<string> returnList = new List<string>();

            string[] inputArray = input.Split(separator);

            foreach (string name in inputArray)
            {
                if (string.IsNullOrWhiteSpace(name) == false)
                    returnList.Add(name.Trim());
            }

            return returnList.ToArray();
        }

        private static bool getErrors()
        {
            Console.WriteLine("Vill du se error-meddelanden, default är ja ");
            string input = Console.ReadLine();
            //// Filläsning av no.txt
            ///
            //var nos = System.IO.File.ReadAllLines(@"C:\Projekt\Accelerated Learning\C#\CsharpexErcises\no.txt");
            //
            //foreach (string no in nos)
            //{
            //    if (no == input)
            //    {
            //        Console.WriteLine(input + " == " + no);
            //        return false;
            //    }
            //}


            ////XML Lösning?
            //XmlDocument doc = new XmlDocument();
            //doc.Load(@"C:\Projekt\Accelerated Learning\C#\CsharpexErcises\XMLTest.xml");
            //XmlNode node = doc.DocumentElement.SelectSingleNode(" collection/ book/title");
            //Console.WriteLine(node.InnerText);

            return !string.Equals(input, "no", StringComparison.OrdinalIgnoreCase);
        }

        private static char getSeparator()
        {
            Console.WriteLine("Ange separator, default är ' ' ");
            string input = Console.ReadLine();
            if (input.Length != 1)
                return ' ';
            return input[0];
        }

        private static void Uppgift1o2()
        {
            string input = Helpers.getString("Ange namn separerade med mellanslag");
            input = input.ToUpper();

            string[] inputArray = input.Split(',');

            cleanUpArray(inputArray);
            prepareArrayForWriting(inputArray);

            Helpers.writeInColor(inputArray, ConsoleColor.Green);
        }

        private static void cleanUpArray(string[] inputArray)
        {
            char[] charsToRemove = { ',', '.', 'Å', 'Ä', 'Ö' };
            for (int i = 0; i < inputArray.Length; i++)
            {
                foreach (char c in charsToRemove)
                {
                    inputArray[i] = inputArray[i].Replace(c.ToString(), "");
                }
                inputArray[i] = inputArray[i].Trim();
            }
        }

        protected static void prepareArrayForWriting(string[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = $"***SUPER-{char.ToUpper(inputArray[i][0]) + inputArray[i].Substring(1)}***";
            }
        }
    }
}
