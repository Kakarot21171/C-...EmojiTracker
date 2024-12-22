using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Class1
    {

        public class Symbol
        {
            public char symbol;
            public int uses;
            public double frequency;

            public Symbol(char symbol)
            {
                this.symbol = symbol;
                this.uses = 0;
                this.frequency = 0.0;
            }
        }

        
        public class Program
        {
            static void Main(string[] args)
            {
                Symbol[] symbols = new Symbol[9]
                {
                new Symbol('\u221E'), // ∞
                new Symbol('\u263A'), // ☺
                new Symbol('\u2640'), // ♀
                new Symbol('\u2642'), // ♂
                new Symbol('\u2660'), // ♠
                new Symbol('\u2663'), // ♣
                new Symbol('\u2665'), // ♥
                new Symbol('\u2666'), // ♦
                new Symbol('\u266B')  // ♫
                };

                while (true)   
                {
                    DisplayMenu(symbols);
                    int choice = GetUserChoice();

                    if (choice == 0)
                    {
                        Console.WriteLine("Shutting off...");
                        break;
                    }
                    else if (choice > 0 && choice <= symbols.Length)
                    {
                        symbols[choice - 1].uses++;
                        Console.WriteLine($"You selected the {symbols[choice - 1].symbol} symbol.");
                        UpdateFrequencies(symbols);
                        SortSymbols(symbols);
                    }
                    else
                    {
                        Console.WriteLine("Invalid option!");
                    }
                }
            }

            static void DisplayMenu(Symbol[] symbols)
            {
                Console.WriteLine("\n[Symbol Recommender]");
                for (int i = 0; i < symbols.Length; i++)
                {
                    Console.WriteLine($"{i + 1} - {symbols[i].symbol}");
                }
                Console.WriteLine("0 - Exit");
            }

            static int GetUserChoice()
            {
                Console.Write("Please select a symbol to print: ");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    return choice;
                }
                return -1;
            }

            static void UpdateFrequencies(Symbol[] symbols)
            {
                int totalUses = 0;
                foreach (var symbol in symbols)
                {
                    totalUses += symbol.uses;
                }

                foreach (var symbol in symbols)
                {
                    if (totalUses > 0)
                    {
                        symbol.frequency = (double)symbol.uses / totalUses;
                    }
                }
            }

            static void SortSymbols(Symbol[] symbols)
            {
                for (int i = 0; i < symbols.Length - 1; i++)
                {
                    for (int j = 0; j < symbols.Length - i - 1; j++)
                    {
                        if (symbols[j].frequency < symbols[j + 1].frequency ||
                            (symbols[j].frequency == symbols[j + 1].frequency && symbols[j].symbol > symbols[j + 1].symbol))
                        {
                            var temp = symbols[j];
                            symbols[j] = symbols[j + 1];
                            symbols[j + 1] = temp;
                        }
                    }
            }
        }
    }





}
}
