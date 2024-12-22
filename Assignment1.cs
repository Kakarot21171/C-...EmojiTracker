using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Assignment1
{
    public class Symbol
    {
       public char symbol;
       public int uses;
       public double frequency;

        public Symbol(char input)
        {
            this.symbol = input;
            this.uses = 0;
            this.frequency = 0;
        } 
    }
    public class Assignment1
    {
        public string Symbol_order = "";

        public static void updateFrequencies(Symbol[] arr)
        {
            // int totalUses = arr.Sum(s => s.uses); // Calculate total uses of all symbols

            int totalUses = 0;
            foreach (Symbol c in arr)
            {
                totalUses += c.uses;
            }
            
            foreach (Symbol c in arr)
            {
                if (totalUses == 0) {
                }
                c.frequency = c.uses / totalUses;

                else
                {
                    c.frequency = c.uses / totalUses;
                }

                //c.frequency = totalUses == 0 ? 0 : (double)c.uses / totalUses; // Calculate frequency relative to total uses
            }
        }

        //public static void updateFrequencies(Symbol[] arr)
        //{

        //    foreach (Symbol c in arr)
        //    {
        //        switch (c.symbol)
        //        {
        //            case '\uA263':
        //                c.uses++;
        //                break;
        //            case '\u263A':
        //                c.uses++;
        //                break;
        //            case '\u2640':
        //                c.uses++;
        //                break;
        //            case '\u2642':
        //                c.uses++;
        //                break;
        //            case '\u2660':
        //                c.uses++;
        //                break;
        //            case '\u2663':
        //                c.uses++;
        //                break;
        //            case '\u2665':
        //                c.uses++;
        //                break;
        //            case '\u2666':
        //                c.uses++;
        //                break;
        //            case '\u266B':
        //                c.uses++;
        //                break;
        //        }

        //        c.frequency = c.uses / arr.Length;

        //    }




        //}



        static void sortSymbols(Symbol[] symbols)
        {
            int n = symbols.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (symbols[j].frequency < symbols[j + 1].frequency)
                    {
                        Swap(symbols, j, j + 1);
                    }
                    else if (symbols[j].frequency == symbols[j + 1].frequency && symbols[j].symbol > symbols[j + 1].symbol)
                    {
                        Swap(symbols, j, j + 1);
                    }
                
            }
        }
        static void Swap(Symbol[] symbols, int i, int j)
        {
            Symbol temp = symbols[i];
            symbols[i] = symbols[j];
            symbols[j] = temp;
        }
        static void Main(string[] args)
        {
            Symbol[] symbols = new Symbol[9];
            symbols[0] = new Symbol('\u221E');
            symbols[1] = new Symbol('\u263A');
            symbols[2] = new Symbol('\u2640');
            symbols[3] = new Symbol('\u2642');
            symbols[4] = new Symbol('\u2660');
            symbols[5] = new Symbol('\u2663');
            symbols[6] = new Symbol('\u2665');
            symbols[7] = new Symbol('\u2666');
            symbols[8] = new Symbol('\u266B');

            Console.WriteLine("[Symbol Recommender]");
            int choice;
            //Console.WriteLine(symbols[0].uses);

            do
            {

                Console.WriteLine("Here are all available symbols");

                for (int i = 0; i < symbols.Length; i++)
                {
                    Console.WriteLine($"{i + 1} - {symbols[i].symbol}");
                }
                //Console.WriteLine($"{symbols[0].uses} uses");

                Console.Write("Please select a symbol to print: ");
                choice = int.Parse(Console.ReadLine());

                Symbol selectedSymbol = symbols[choice - 1];
                if (choice == 0) 
                {
                    Console.WriteLine("Shutting off...");
                }
                else if (choice > 9 || choice < 1)
                {
                    Console.WriteLine("Invalid option!");
                }
                else
                {
                    Console.WriteLine($"\nYou selected the {selectedSymbol.symbol} symbol.\n");
                    selectedSymbol.uses += 1;

                    updateFrequencies(symbols);
                    sortSymbols(symbols);
                }
            } while (choice != 0);

        }





    }
}
