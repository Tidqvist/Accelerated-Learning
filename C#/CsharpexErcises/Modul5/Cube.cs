using System;

namespace Modul5
{
    internal class Cube
    {
        public static Cube add(Cube c1, Cube c2)
        {
            var color = c1.Colour == c2.Colour ? c1.Colour : ConsoleColor.White;

            return new Cube(c1.v1 + c2.v1, c1.v2 + c2.v2, c1.v3 + c2.v3, color);
        }

        private double v1;
        private double v2;
        private double v3;

        public ConsoleColor Colour { get; set; }

        public decimal Volume { get => (decimal)(v1 * v2 * v3); }


        public decimal Area { get => (decimal)((v1 * v2) * 2 + (v2 * v3) * 2 + (v1 * v3) * 2); }

        public Cube(double v1, double v2, double v3, ConsoleColor colour)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            Colour = colour;
        }

        public Cube(double v1, double v2, double v3) : this(v1, v2, v3, ConsoleColor.White)
        {
        }

        public Cube(double v) : this(v, v, v)
        {
        }

        public static Cube CreateCubeFromVolume(double volume)
        {
            return new Cube(Math.Pow(volume, (1.0 / 3.0)), Math.Pow(volume, (1.0 / 3.0)), Math.Pow(volume, (1.0 / 3.0)));
        }

        internal void WriteVolume()
        {
            Console.WriteLine("The volume of the cube is: " + (v1 * v2 * v3));
        }

        internal double CalculateVolume()
        {
            return v1 * v2 * v3;
        }

        internal double CalculateArea()
        {
            return ((v1 * v2) * 2 + (v2 * v3) * 2 + (v1 * v3) * 2);
        }

        internal bool IsCubical()
        {
            return v1.Equals(v2) && v1.Equals(v3);
        }

        internal static ConsoleColor AskForColour()
        {
            Console.Clear();

            Console.WriteLine("Ange index för den färg du vill ändra till");

            var colors = Enum.GetNames(typeof(ConsoleColor));

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine((int)(ConsoleColor)(i) + " " + (ConsoleColor)(i));
            }

            int index;
            do
            {

                index = MagnusHelpers.Helpers.getIntBetween(0,colors.Length);
            } while (index > colors.Length | index < 0);
            //foreach (var color in colors)
            //{
            //    Console.WriteLine(colors.color);
            //}
            return (ConsoleColor)(index);
        }
    }
}