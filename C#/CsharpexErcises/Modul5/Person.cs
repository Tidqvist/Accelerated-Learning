using System;

namespace Modul5
{
    internal class Person
    {
        private string FirstName;
        private string LastName;
        private DateTime BirthDay;
        private Sports FavoriteSport;
        private Genders Gender;

        public Person(string v1, string v2, DateTime dateTime, Sports favouriteSport, Genders gender)
        {
            this.FirstName = v1;
            this.LastName = v2;
            this.BirthDay = dateTime;
            this.FavoriteSport = favouriteSport;
            this.Gender = gender;
        }

        internal void About()
        {
            Console.WriteLine($"{FirstName} {LastName} is a {Gender} and likes to play {FavoriteSport}");
        }

                public enum Sports
        {
            Tennis,
            Rugby,
            Soccer,
            Hurling,
            Squash
        };

        public enum Genders
        {
            Male,
            Female,
            Other
        };
    }
}