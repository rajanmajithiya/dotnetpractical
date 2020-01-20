using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace practical_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            string country;

            do
            {
                Console.WriteLine("Enter your name:");
                name = Console.ReadLine();
            } while (!Regex.IsMatch(name, "^[a-zA-Z]+$"));

            do
            {
                Console.WriteLine("Enter your Country");
                country = Console.ReadLine();
            } while (!Regex.IsMatch(country, "^[a-zA-Z]+$"));

            Console.WriteLine("HI" + name + "your country is " + country);
        

        }
    }
}
