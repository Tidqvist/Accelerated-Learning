using System;

namespace Helpers
{
    public class magnusHelpers
    {
        public static void pressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        public  static int getNumber(string s)
        {
            int inputnumber;
            do
            {
                Console.Write(s);
            } while (int.TryParse(Console.ReadLine(), out inputnumber) == false);
            return inputnumber;
        }
        public  static int getNumber()
        {
            return getNumber("Ange ett tal: ");
        }

    }
}
