using System;
using System.Text;
using MagnusHelpers;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //uppgift1();
                //uppgift1v2();
                // uppgift3();
                // uppgift4();
                //uppgift5();
                //uppgift16();
                //uppgift7();
                uppgift8();

                Helpers.pressAnyKeyToContinue();
            } while (true);

        }

        private static void uppgift8()
        {
            int inputnumber;
            int comparenumber;

            Console.WriteLine("Du ska nu gisas dig fram till ett hemligt tal! \nAnge först en övre och undre gräns för det hemliga talet");

            int loverbound = Helpers.getInt("Undre gräns: ");
            int upperbound = Helpers.getInt("Övre gräns: ");

            Random randomizer = new Random();
            comparenumber = randomizer.Next(loverbound, upperbound);
            int counter = 0;
            do
            {
                inputnumber = Helpers.getInt("Ange ett tal: ");

                // string message = (inputnumber == comparenumber) ? "Rätt" : (inputnumber < comparenumber ? "För lågt" : "För högt");

                string message =
                                (inputnumber < comparenumber) ? //Utvärdera 

                /* om rätt */          "För lågt" :
                /* om fel  */          (inputnumber > comparenumber ? //utvärdera

                /* om rätt */               "För högt" :
                /* om fel */               "Lika!");

                Console.WriteLine(message);
                counter++;
            } while (inputnumber != comparenumber && counter <6);
        }

        private static void uppgift7()
        {
            int inputnumber;
            int comparenumber;

            Console.WriteLine("Du ska nu gisas dig fram till ett hemligt tal! \nAnge först en övre och undre gräns för det hemliga talet");

            int loverbound = Helpers.getInt("Undre gräns: ");
            int upperbound = Helpers.getInt("Övre gräns: ");

            Random randomizer = new Random();
            comparenumber = randomizer.Next(loverbound, upperbound);

            do
            {
                inputnumber = Helpers.getInt("Ange ett tal: ");

                //do
                //{
                //    Console.WriteLine("Ange ett tal att jämföra med: ");
                //} while (int.TryParse(Console.ReadLine(), out comparenumber) == false);

                if (inputnumber == comparenumber)
                    break;
                else if (inputnumber < comparenumber)
                    Console.Write($"{inputnumber} är för lågt! ");
                else if (inputnumber > comparenumber)
                    Console.Write($"{inputnumber} är för högt! ");

                if (Math.Abs(inputnumber - comparenumber) < (upperbound - loverbound) / 10)
                    Console.WriteLine("Men det är nära... gissa igen: ");
                else
                    Console.WriteLine("Gissa igen: ");

            } while (true);

            Console.WriteLine($"\n{inputnumber} är rätt!");
        }


        private static void uppgift16()
        {
            while (true)
            {
                Console.ResetColor();
                Console.WriteLine("Enter names separated with commas ','");
                string input = Console.ReadLine();

                string[] inputList = input.Split(',');

                bool allowZelda = false;

                foreach (string namn in inputList)
                {
                    if (namn.ToLower().Contains("zelda") && namn.ToLower().Contains("allow"))
                        allowZelda = true;
                }

                foreach (string namn in inputList)
                {
                    if (namn.ToLower().Contains("zelda")) //Om zelda inte är tillåtet (bool allowZelda) och zelda finns i namnet -> break
                    {
                        if (allowZelda == false)
                            break;
                        else if (namn.ToLower().Contains("allow"))
                            continue;
                    }
                    else if (namn.ToLower().Contains("listcolor"))
                    {
                        if (namn.ToLower().Contains("green"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (namn.ToLower().Contains("blue"))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                    }
                    else //Hit kommer vi om våra två specialfall inte är uppfyllda. 1. vi har inte passerat "zelda" där zelda inte är tillåtet eller även innehåller "allow" 
                    {
                        Console.WriteLine($"{UppercaseFirst(namn.Trim())} Tidqvist");
                    }
                }
            }
        }
        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private static void uppgift5()
        {
            Console.WriteLine("Enter names separated with commas ','");
            string input = Console.ReadLine();

            string[] inputList = input.Split(',');

            for (int i = 0; i < inputList.Length; i++)
            {
                if (inputList[i].Length < 5 | inputList[i].Length > 15)
                {
                    Console.WriteLine($"Ett namn måste vara mellan 5-15 bokstäver, skriv in ett nytt namn som ersätter {inputList[i]} eller lämna blankt för att ta bort {inputList[i]}");
                    var newname = Console.ReadLine();
                    inputList[i] = newname;
                }
            }

            Console.WriteLine("Listan innehåller följande namn");
            for (int i = 0; i < inputList.Length; i++)
            {
                if (!string.IsNullOrEmpty(inputList[i]))
                {
                    Console.WriteLine("[" + i + "] " + inputList[i].Trim());
                }
            }
            Console.WriteLine("I vilken ordning vill du visa namnen? Ange siffror separerade med mellanslag ' '");
            var orderString = Console.ReadLine();
            var orderStringArray = orderString.Split(' ');
            int[] orderIntArray = new int[orderStringArray.Length];

            for (int i = 0; i < orderStringArray.Length; i++)
            {
                orderIntArray[i] = int.Parse(orderStringArray[i]);
            }


            Console.WriteLine("Enter a surname: ");
            var surname = Console.ReadLine();

            for (int i = 0; i < inputList.Length; i++)
            {
                if (!string.IsNullOrEmpty(inputList[orderIntArray[i]]))
                {
                    Console.WriteLine("[" + i + "] " + inputList[orderIntArray[i]].Trim() + " " + surname);
                }
            }
        }

        private static void uppgift4()
        {
            while (true)
            {
                string output;

                Console.WriteLine("Ange ett namn: ");
                string name = Console.ReadLine();
                while (string.IsNullOrEmpty(name) | name.Length < 3 | name.Length > 10)
                {
                    if (string.IsNullOrEmpty(name))
                        Console.WriteLine("Du måste ange ett värde");
                    else
                        Console.WriteLine("Namnet måste vara mellan 3 och 10 bokstäver långt");
                    Console.WriteLine("Ange ett namn: ");
                    name = Console.ReadLine();
                }

                int antalKolumner = 0;
                Console.WriteLine("Ange antal kolumner ");
                while (!int.TryParse(Console.ReadLine(), out antalKolumner))
                {
                    Console.WriteLine("Talet måste vara ett heltal");
                }

                int antalRader = 0;
                Console.WriteLine("Ange antal rader ");
                while (!int.TryParse(Console.ReadLine(), out antalRader))
                {
                    Console.WriteLine("Talet måste vara ett heltal");
                }

                bool backwards = false;
                Console.WriteLine("Baklänges? om ja skriv 'y'");
                if (Console.ReadLine() == "y")
                    backwards = true;

                if (backwards)
                {
                    var nameCharArray = name.ToCharArray();
                    char[] backwordNameCharArray = new char[nameCharArray.Length];
                    for (int i = 0; i < nameCharArray.Length; i++)
                    {
                        backwordNameCharArray[i] = nameCharArray[nameCharArray.Length - i - 1];
                    }
                    StringBuilder s = new StringBuilder();
                    s.Append(name);
                    s.Append(new string(backwordNameCharArray));
                    output = s.ToString();

                }
                else
                    output = name;

                int antalRepetitioner = 0;
                Console.WriteLine("Ange antal repetitioner ");
                while (!int.TryParse(Console.ReadLine(), out antalRepetitioner))
                {
                    Console.WriteLine("Talet måste vara ett heltal");
                }

                for (int i = 0; i < antalRepetitioner; i++)
                {
                    output = output + output;
                }

                for (int r = 0; r < antalRader; r++)
                {
                    for (int k = 0; k < antalKolumner; k++)
                    {
                        Console.Write(string.Format("{0,-30}", output));
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void uppgift3()
        {
            string name = "";
            //Console.WriteLine("Ange ett namn: ");
            //while (name.Length > 10 || name.Length < 5)
            //{
            //    Console.WriteLine("Namnet måste vara mellan 5 och 10 bokstäver långt ");
            //    name = Console.ReadLine();
            //}

            //do
            //{
            //    Console.WriteLine("Namnet måste vara mellan 5 och 10 bokstäver långt ");
            //    name = Console.ReadLine();
            //} while (name.Length > 10 || name.Length < 5);

            //name = null;

            Console.WriteLine("Ange ett namn: ");
            name = Console.ReadLine();
            while (string.IsNullOrEmpty(name) | name.Length < 3 | name.Length > 10)
            {
                if (string.IsNullOrEmpty(name))
                    Console.WriteLine("Du måste ange ett värde");
                else
                    Console.WriteLine("Namnet måste vara mellan 3 och 10 bokstäver långt");
                Console.WriteLine("Ange ett namn: ");
                name = Console.ReadLine();
            }

            int timesToRepeat = 0;
            Console.WriteLine("Times to repeat: ");
            while (!int.TryParse(Console.ReadLine(), out timesToRepeat) | (timesToRepeat > 10 | timesToRepeat < 5))
            {
                Console.WriteLine("Talet måste vara mellan 5 och 10 ");
            }

            string presentation = "";

            while (true)
            {
                Console.WriteLine("Ange om du vill visa på en linje (ange 'en rad') eller flera linjer (ange 'flera rader')");
                presentation = Console.ReadLine();
                if (presentation == "en rad")
                {
                    oneLineWhile(name, timesToRepeat);
                    break;
                }
                else if (presentation == "flera rader")
                {
                    severalLinesWhile(name, timesToRepeat);
                }
            }


            baraWhile(name, timesToRepeat);

            DoWhile(name, timesToRepeat);

        }

        private static void severalLinesWhile(string name, int timesToRepeat)
        {
            Console.WriteLine("Whileloop");
            int i = 0;
            while (i < timesToRepeat)
            {

                if (i == timesToRepeat)
                {
                    break;
                }
                Console.WriteLine("Your name is " + name);
                i++;
            }
        }

        private static void oneLineWhile(string name, int timesToRepeat)
        {
            Console.WriteLine("Whileloop");
            int i = 0;
            while (i < timesToRepeat)
            {

                if (i == timesToRepeat)
                {
                    break;
                }
                Console.Write("Your name is " + name + ", ");
                i++;
            }
        }

        private static void baraWhile(string name, int timesToRepeat)
        {
            Console.WriteLine("Whileloop");
            int i = 0;
            while (i < timesToRepeat)
            {

                if (i == timesToRepeat)
                {
                    break;
                }
                Console.WriteLine("Your name is " + name);
                i++;
            }
        }

        private static void DoWhile(string name, int timesToRepeat)
        {
            int i;
            Console.WriteLine("Do-while-loop");
            i = 0;
            do
            {
                Console.WriteLine("Your name is " + name);
                i++;
            } while (i < timesToRepeat);
        }

        private static void uppgift1v2()
        {
            string input;


            Console.WriteLine("When did you go to bed yestorday?");
            input = Console.ReadLine();

            DateTime wentToBed, wokeUp;

            wentToBed = dateTimefromString(input);

            Console.WriteLine("When did you go wake up?");
            input = Console.ReadLine();

            wokeUp = dateTimefromString(input);

            TimeSpan sleptHours = wokeUp - wentToBed;
            Console.WriteLine(sleptHours.TotalHours);
        }

        private static DateTime dateTimefromString(string input)
        {
            input.ToLower();
            DateTime dateTime;
            if (!DateTime.TryParse(input, out dateTime))
            {
                int kolon = input.IndexOf(':');
                string klockslag = input.Substring(kolon - 2, 5);

                dateTime = DateTime.Parse(klockslag);

                if (input.Contains("yestorday"))
                {
                    dateTime = dateTime - TimeSpan.FromDays(1);
                }
                else if (input.Contains("tomorrow"))
                {
                    dateTime = dateTime + TimeSpan.FromDays(1);
                }
            }

            return dateTime;
        }

        private static void uppgift1()
        {
            int wentToBed;
            int wokeUp;

            do
            {
                Console.WriteLine("When did you go to bed yestorday?");
                wentToBed = int.Parse(Console.ReadLine());

                Console.WriteLine("When did you wake up?");
                wokeUp = int.Parse(Console.ReadLine());
                int sleptHours;

                if (wentToBed < wokeUp)
                {
                    sleptHours = wokeUp - wentToBed;
                }
                else
                    sleptHours = (24 - wentToBed) + wokeUp;

                if (sleptHours < 6)
                {
                    Console.WriteLine("Go back to sleep. ({0} Hours)", sleptHours);
                }
                else if (sleptHours > 10)
                {
                    Console.WriteLine("You slept ALOT! ({0} Hours)", sleptHours);
                }
                else
                {
                    Console.WriteLine("You slept well. ({0} Hours)", sleptHours);
                }

            } while (true);
        }
    }
}
