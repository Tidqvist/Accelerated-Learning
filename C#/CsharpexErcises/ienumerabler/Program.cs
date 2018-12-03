using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ienumerabler
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Element> elements = BuildDictionary();

            var subset = from element in elements
                         where element.Value.AtomicNumber < 21
                         orderby element.Value.Name
                         select element;

            foreach (var element in subset)
            {
                Console.WriteLine(element.Value.Name);
            }


        }


        public static Dictionary<string, Element> BuildDictionary()
        {
            var elements = new Dictionary<string, Element>();

            AddToDictionary(elements, "K", "Potassium", 19);
            AddToDictionary(elements, "Ca", "Calcium", 20);
            AddToDictionary(elements, "Sc", "Scandium", 21);
            AddToDictionary(elements, "Ti", "Titanium", 22);

            return elements;
        }

        public static void AddToDictionary(Dictionary<string, Element> elements,
            string symbol, string name, int atomicNumber)
        {
            Element theElement = new Element();

            theElement.Symbol = symbol;
            theElement.Name = name;
            theElement.AtomicNumber = atomicNumber;

            elements.Add(key: theElement.Symbol, value: theElement);
        }

        public class Element
        {
            public string Symbol { get; set; }
            public string Name { get; set; }
            public int AtomicNumber { get; set; }
        }
        public static IEnumerable<int> GetSingleDigitNumbers()
        {
            int index = 0;
            while (index++ < 10)
                yield return index;

            yield return 50;

            index = 100;
            while (index++ < 110)
                yield return index;
        }

        private static void Decks()
        {
            var startingDeck = from s in Suits() from r in Ranks() select new { Suit = s, Rank = r };

            // Display each card that we've generated and placed in startingDeck in the console
            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }
        }

        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
    }
}
