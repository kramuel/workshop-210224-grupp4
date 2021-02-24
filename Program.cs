using System;

namespace WorkShopV8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dealer d1 = new Dealer();
            d1.requestCard();

            d1.showCards();

            Console.ReadKey();
        }
    }
}
