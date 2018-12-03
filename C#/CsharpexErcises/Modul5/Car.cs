using System;
using System.Collections.Generic;
using System.Text;

namespace Modul5
{
    class Car
    {
        private int weight;
        private int length;

        public CarColour Colour { get; private set; }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public int Length { get => length;  set => length = value; }



        //CONSTRUCTORS
        public Car() : this(CarColour.UnColourd)
        {
        }

        public Car(CarColour colour)
        {
            this.Colour = colour;
        }

        public Car(int weight, int length) : this(CarColour.UnColourd) {
            this.Weight = weight;
            this.Length = length;
        }

        public Car(CarColour colour, int weight, int length)
        {
            this.Colour = colour;
            this.Weight = weight;
            this.Length = length;
        }



        //SET
        public void setColour (CarColour colour)
        {
            //Logik, validering...

            Colour = colour; 
        }

        //ENUM
        public enum CarColour
        {
            UnColourd,
            Red,
            Blue,
            Green,
            Black,
            White
        };
    }

}
