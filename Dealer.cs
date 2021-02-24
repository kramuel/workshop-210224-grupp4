using System;
using System.Collections.Generic;

namespace WorkShopV8
{
    class Dealer
    {
        private Deck _dealerDeck;
        public List<Card> _dealerHand;

        public Dealer()
        {
            _dealerDeck = new Deck();
            _dealerHand = new List<Card>();
        }

        public void requestCard()
        {
            Random rmg = new Random();
            int index = rmg.Next(0, _dealerDeck._deck.Count);
            _dealerHand.Add(_dealerDeck._deck[index]);
            _dealerDeck._deck.RemoveAt(index);

        }
        public void showCards()
        {
            foreach (Card card in _dealerHand)
            {
                card.PrintCard();
            }
        }

    //     public static Deck getDeck(){
    //     //loopa o fixa en lista deck eller nåt
        
    //     return 1;
    //}
    }


    
}
