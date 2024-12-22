using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment1
{
    public class Symbol
    {
        char symbol;
        int uses;
        double frequency;

        public Symbol(char one)
        {

        }
    }
    public class Program
    {
        public static void updateFrequencies(char[] input)
        {
            char[] symbol = new char[9];
            symbol[0] = '\u221E';
            symbol[1] = '\u263A';
            symbol[2] = '\u2640';
            symbol[3] = '\u2642';
            symbol[4] = '\u2642';
            symbol[5] = '\u2660';
            symbol[6] = '\u2663';
            symbol[7] = '\u2665';
            symbol[8] = '\u2666';
            symbol[9] = '\u266B';
            
            
            switch (symbol[0])
            {
                case '\u221E':

                    break;

            }
    }
        public static void sortSymbols(char[] input)
        {

        }
        public static void printSymbols() 
        {
            Console.WriteLine("1-\u221E");
            Console.WriteLine("2-\u263A");
            Console.WriteLine("3-\u2640");
            Console.WriteLine("4-\u2642");
            Console.WriteLine("5-\u2660");
            Console.WriteLine("6-\u2663");
            Console.WriteLine("7-\u2665");
            Console.WriteLine("8-\u2666");
            Console.WriteLine("9-\u266B");
            Console.WriteLine("0-Exit");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("[Symbol Recommender]");
            Console.WriteLine("Here are all available symbols");
            printSymbols();
            Console.WriteLine("Please select a symbol to print:");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nYou selected the symbol");

        }





    }
}
