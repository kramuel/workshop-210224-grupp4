using System;
using System.Collections.Generic;

namespace WorkShopV8
{
    class Player
    {

        private Deck _dealerDeck;
        public List<Card> _playerHand;

        public Player(Deck deck)
        {
            _dealerDeck = deck;
            _playerHand = new List<Card>();
        }

        public void requestCard()
        {
            Random rmg = new Random();
            int index = rmg.Next(0, _dealerDeck._deck.Count);
            _playerHand.Add(_dealerDeck._deck[index]);
            _dealerDeck._deck.RemoveAt(index);

        }

        public void showCards()
        {
            foreach (Card card in _playerHand)
            {
                card.PrintCard();
            }
        }

    }
}
