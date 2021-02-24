using System;
using System.Collections.Generic;

namespace WorkShopV8
{
    class Dealer
    {
        private Deck _dealerDeck;
        public List<Card> _dealerHand;

        public Dealer(Deck deck)
        {
            _dealerDeck = deck;
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

        public int dealerValueofHand()
        {
            int sum = 0;
            foreach (Card card in _dealerHand)
            {
                sum += card.value();
            }
            return sum;
        }
    }
}
