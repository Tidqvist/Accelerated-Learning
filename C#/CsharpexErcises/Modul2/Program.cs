using System;
using System.Diagnostics;
using System.Text;
using System.Threading;


namespace Modul2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift1();
            //Uppgift2();
            Uppgift3();

            Console.ReadKey();
        }

        private static void Uppgift3()
        {
            int numberOfFruits;
            do
            {
                Console.WriteLine("Number of fruits?");
            } while (!int.TryParse(Console.ReadLine(), out numberOfFruits));

            string[] fruits = new string[numberOfFruits];

            for (int i = 0; i<fruits.Length; i++)
            {
                do
                {
                    Console.WriteLine("Enter fruit " +(i+1));
                    fruits[i] = Console.ReadLine().ToLower().Trim();
                } while (String.IsNullOrEmpty(fruits[i]));
            }

            //Console.WriteLine("You enterd three fruits: " + fruits[0] + " " + fruits[1] + " " + fruits[2]);
            //Console.WriteLine(string.Format("You enterd three fruits: {0} {1} {2}", fruits[0], fruits[1], fruits[2]));
            //Console.WriteLine($"You enterd three fruits: {fruits[0]} {fruits[1]} {fruits[2]}");

            StringBuilder outputString = new StringBuilder();

            outputString.Append($"You enterd {numberOfFruits} fruits:"); //Första delen av strängen som ska skrivas ut
            outputString.AppendLine();
            int containsRange = 0; //Räknare av hur många frukter som innehåller eftersökt text
            foreach (string fruit in fruits)//Går igenom samtliga frukter
            {
                if (fruit.Contains("range")) //Om frukten innehåller texten range adderas 1 till räknare
                    containsRange++;

                outputString.Append(" " + fruit);// Lägg till frukten och ett mellanslag till outputmeddelandet
            }
            outputString.Append(" And " + containsRange + " of them contains the text \"range\""); //Lägger till hur många frukter som innehåller eftersökt text

            Console.WriteLine(outputString);
        }



        private static void Uppgift2()
        {
            int age;
            string name;
            char favouriteCharacter;

            do
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
            } while (String.IsNullOrEmpty(name));

            do
            {
                Console.WriteLine("How old are you?");
            } while (!int.TryParse(Console.ReadLine(), out age));

            do
            {
                Console.WriteLine("Whats your favourite character?");
            } while (!char.TryParse(Console.ReadLine(), out favouriteCharacter));


            if (name == "Magnus" && age == 28 && favouriteCharacter == 'E')
                Console.Beep();

            printStringLikeARainbow($"Your name is: {name}");
            printStringLikeARainbow("You have " + (65 - age) + " years left untill retierment");
            if (Char.IsDigit(favouriteCharacter))
                printStringLikeARainbow("You like numbers");
            else
                printStringLikeARainbow($"Your favourite character is: {favouriteCharacter}");

        }

        private static void Uppgift1()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            name = $"Your name is: {name}";
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            age = $"Your are {age} years old";
            Console.WriteLine("What is your favourite letter?");
            string letter = Console.ReadLine();
            letter = $"Your favourite letter is {letter}";

            Console.WriteLine("\nThank you!\n");

            printStringLikeARainbow(name);
            printStringLikeARainbow(age);
            printStringLikeARainbow(letter);

        }

        private static void printStringLikeARainbow(string stringToWrite)
        {
            for (int i = 0; i < stringToWrite.Length; i++)
            {
                Console.ForegroundColor = (ConsoleColor)(i % 14);
                Console.Write(stringToWrite[i]);
            }
            Console.WriteLine();
        }
    }
}
