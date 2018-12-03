using System;
using System.Collections.Generic;
using MagnusHelpers;


namespace Modul5
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Uppgift1();
                //Uppgift2();
                //Uppgift3();
                //Uppgift14();
                Uppgift5();
                //Uppgift6();

            } while (Helpers.askIfExit() == false);
        }

        private static void Uppgift6()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //DrawSquare(Helpers.getInt("Storlek på fyrkant: "), Helpers.getInt("Marginal: "));
            Multi.MultiplicationTable(3, 2);
        }



        private static void DrawSquare(int x)
        {
            DrawSquare(x, 0);
        }

        private static void DrawSquare(int x, int margin)
        {
            Console.WriteLine();

            for (int i = 0; i < x; i++)
            {
                for (int m = 0; m < margin; m++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < x; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        private static void Uppgift5()
        {
            Adress a = new Adress()
            {
                Street = "Långa gatan",
                StreetNumber = "13B",
                City = "Sundsvall",
                //ZipCode = "111 22"
            };
            a.ZipCode = Console.ReadLine();
            Console.WriteLine(a.ZipCode);

            //string[,] array = a.getPropertiesAsArray();


            //foreach (char item in array[,])
            //{
            //    Console.WriteLine(string.Format("{0,-10} {1,-10}", item[0], item[1]));

            //}

            //var list = a.GetList();
            //Console.WriteLine($"StreetNumber\t {a.StreetNumber}");
            //Console.WriteLine($"City\t\t {a.City}");
            //Console.WriteLine($"ZipCode\t\t {a.ZipCode}");
            //Console.WriteLine($"FullStreet\t {a.FullStreet}");

            //Console.WriteLine(nameof(a.Street));


        }

        private static void Uppgift14()
        {
            Person p1 = new Person("Magnus", "Tidqvist", new DateTime(1990, 05, 27), Person.Sports.Tennis, Person.Genders.Male);

            p1.About();

            Console.WriteLine("Here is a list of all Sport enumes:\n");

            string[] sports = Enum.GetNames(typeof(Person.Sports));
            foreach (var sport in sports)
            {
                Console.WriteLine("* " + sport);
            }

            string input = Helpers.getString("\nEnter a sport: ");

            Console.WriteLine(Enum.TryParse(typeof(Person.Sports), input, true, out _) ? "I like " + input : "Oh, I dont know " + input);
        }

        private static void Uppgift3()
        {
            Cube c1 = new Cube(1, 1, 1, ConsoleColor.Blue);
            Cube c2 = new Cube(1, 1, 1, ConsoleColor.Blue);
            Cube c3 = new Cube(100, 200, 300);
            Cube c4 = new Cube(100, 200, 300, ConsoleColor.Red);
            Cube c5 = new Cube(1);


            List<Cube> list = new List<Cube>();

            list.Add(c1);
            list.Add(c2);
            list.Add(c3);
            list.Add(c4);
            list.Add(Cube.add(c1, c2));
            list.Add(Cube.add(c3, c4));
            list.Add(c5);
            do
            {
                Console.Clear();
                Console.WriteLine("Vilket index vill du ändra på?");

                foreach (var cube in list)
                {
                    Helpers.writeInColor($"[{list.IndexOf(cube)}] Volume: {cube.CalculateVolume()} {cube.Volume} Area: {cube.CalculateArea()} {cube.Area} Colour: {cube.Colour} Is cubical? {cube.IsCubical()}", cube.Colour);
                }

                int index = Helpers.getIntBetween(0, list.Count);

                Console.Clear();
                int action;

                action = Helpers.getInt("Ange vad du vill göra: \n1 Byta färg");
                switch (action)
                {
                    case 1:
                        list[index].Colour = Cube.AskForColour();
                        break;
                    default:
                        break;
                }

            } while (true);


        }

        private static void Uppgift2()
        {
            Circle c1 = new Circle("Bob", 8);
            Circle c2 = new Circle("Lisa", 30);
            Circle c3 = new Circle("Alice");
            Circle c4 = new Circle();

            var list = new List<Circle>();

            list.Add(c1);
            list.Add(c2);
            list.Add(c3);
            list.Add(c4);

            foreach (var item in list)
            {
                item.SayHello();
            }

            Console.WriteLine();


            foreach (var item in list)
            {
                item.WriteArea();
            }


        }

        private static void Uppgift1()
        {
            var c1 = new Car(Car.CarColour.Red, 1000, 4);
            var c2 = new Car(200, 8);
            var c3 = new Car(Car.CarColour.Green);
            var c4 = new Car();


            var list = new List<Car>();

            list.Add(c1);
            list.Add(c2);
            list.Add(c3);
            list.Add(c4);

            foreach (Car car in list)
            {
                Console.WriteLine("Bilen {0} är {1} och väger {2} kg och är {3} m lång", list.IndexOf(car), car.Colour, car.Weight, car.Length);
            }


            //Console.WriteLine("Bilen {0} är {1} och väger {2} kg", nameof(c1), c1.GetColor(), c1.GetWeight());
            //Console.WriteLine("Bilen {0} är {1} och väger {2} kg", nameof(c2), c2.GetColor(), c2.GetWeight());
            //Console.WriteLine("Bilen {0} är {1} och väger {2} kg", nameof(c3), c3.GetColor(), c3.GetWeight());

            //Console.WriteLine(c1.colorEnume);


            Helpers.pressAnyKeyToContinue();
        }
    }


}
