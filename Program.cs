using System;

namespace WorkShopV8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Deck deck = new Deck();
            deck.PrintDeck();

            Console.ReadKey();
        }
    }
}
