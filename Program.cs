using System;

namespace WorkShopV8
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Dealer d1 = new Dealer(deck);
            Player p1 = new Player(deck,100);
            bool quit = false;

            while(!quit)
            {
                // Give player first card
                p1.requestCard();
                PrintPlayerHand(p1);

                // Ask player how much they want to bet
                Console.Write("\nHur mycket vill du satsa?: ");
                int bet = Convert.ToInt32(Console.ReadLine());
                if(bet <= p1.playerPoints())
                {
                    p1.requestCard();
                    PrintPlayerHand(p1);
                    if(p1.playerValueofHand() > 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Du hamnade över 21, du förlorade");
                        Console.ResetColor();
                        quit = true;
                        break;
                    }
                    else if(p1.playerValueofHand() == 21)
                    {
                        PrintPlayerHand(p1);
                        Victory(p1,bet);       
                    }
                    for (int i = 0; i <= 3; i++)
                    {
                        Console.WriteLine("Vill du ta ett till kort eller stanna?: (1 & 2)");
                        int userInput = Convert.ToInt32(Console.ReadLine());
                        if(userInput == 1)
                        {
                            p1.requestCard();
                            PrintPlayerHand(p1);
                            if(p1.playerValueofHand() > 21)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Du hamnade över 21, du förlorade");
                                Console.ResetColor();
                                quit = true;
                                break;
                            }
                        }
                        else if(userInput == 2)
                        {
                            Console.WriteLine("Du har valt att stanna på " + p1.playerValueofHand() + " poäng");
                            d1.requestCard();
                            d1.requestCard();
                            d1.requestCard();
                            d1.requestCard();
                            d1.requestCard();
                            PrintDealerHand(d1);
                            if(d1.dealerValueofHand() > 21)
                            {
                                PrintPlayerHand(p1);
                                Victory(p1,bet);
                            }
                            else if((21 - p1.playerValueofHand()) < (21 - d1.dealerValueofHand()))
                            {
                                PrintPlayerHand(p1);
                                Victory(p1,bet);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Du förlorade");
                                Console.ResetColor();
                            }
                            quit = true;
                            break;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Nej du!");
                }
            }
        }
        static void PrintPlayerHand(Player p1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Din hand: ");
            p1.showCards();
            Console.Write("Poäng: ");
            Console.WriteLine(p1.playerValueofHand());
            Console.ResetColor();
        }
        static void PrintDealerHand(Dealer d1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Dealer hand: ");
            d1.showCards();
            Console.Write("Poäng: ");
            Console.WriteLine(d1.dealerValueofHand());
            Console.ResetColor();
        }
        static void Victory(Player p1, int bet)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Du har vunnit!");
            p1.addPoints(bet);
            Console.WriteLine($"Kredit: {p1.playerPoints()}");
            Console.ResetColor();
        }
    }
}
