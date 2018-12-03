using System;

namespace Modul5
{
    internal class Circle
    {
        public string Name { get; private set; }
        public int? Radius { get; private set; }
        public bool RadiusHasBeenSet { get => Radius != null; }

        public double? Area {
            get
            {
                return (Radius == null) ? 0 : Math.PI * Radius * Radius;
            }
        }

        public Circle(string name, int radius)
        {
            Name = name;
           // Radius = radius;
        }

        public Circle(string name) : this(name, 5)
        {
        }

        public Circle() : this("unknown", 5)
        {
        }

        internal bool radiusIsSet()
        {
            return (Radius != null);
        }

        internal void SayHello()
        {
            Console.WriteLine($"I'm a {GetType().Name} and my name is {Name}");
        }

        internal void WriteArea()
        {
            //Console.WriteLine(string.Format("My name is {0}. I have the radius of {1} and the area of {2:0.00}", Name,Radius,Area));
            Console.WriteLine($"My name is {Name}. I have the radius of {Radius} and the area of {Area:0.00} and have the radius been set? {this.radiusIsSet()}, eller som vår prop säger {RadiusHasBeenSet}");

        }
    }
}