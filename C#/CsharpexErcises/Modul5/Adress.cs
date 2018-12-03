using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Modul5
{
    public class Adress
    {
       
        public string Street;
        public string StreetNumber;
        public string City;
        public string _zipCode;
        public decimal zipFirst;
        public decimal zipLast;
        public string ZipCode
        {
            get { return _zipCode; }
            set
            {
                if (Regex.IsMatch(value, "^\\d{3}\\s\\d{2}$"))
                {
                    //var matches = Regex.Split(value, "\\s");
                    MatchCollection matches = Regex.Matches(value, "\\d+");
                    foreach (var match in matches)
                    {
                        Console.WriteLine(   match.ToString());
                    }
                    //zipFirst = Decimal.Parse(matches[0]);
                    //zipLast = Decimal.Parse(matches[1]);

                    Console.WriteLine($"first='{zipFirst} last='{zipLast}'");
                    _zipCode = value;
                }
            }
        }

        public string FullStreet { get => Street + " " + StreetNumber; }


        public string GetFullStreet()
        {
            return Street + " " + StreetNumber; 
        }


        internal string[,] getPropertiesAsArray()
        {
            return new string[,] {{ "Street", Street }, { "StreetNumber", StreetNumber }, { "City", City }, { "ZipCode", ZipCode } };
        }
    }
}
