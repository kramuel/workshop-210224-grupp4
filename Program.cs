using System;

namespace WorkShopV8
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Dealer d1 = new Dealer(deck);
            Player p1 = new Player(deck);

            d1.requestCard();
            d1.showCards();
            System.Console.WriteLine("Cards in deck: " +deck._deck.Count);
            p1.requestCard();
            p1.showCards();
            System.Console.WriteLine("Cards in deck: " + deck._deck.Count);
            p1.requestCard();
            p1.showCards();
            System.Console.WriteLine("Cards in deck: " + deck._deck.Count);

            Console.ReadKey();
        }
    }
}
