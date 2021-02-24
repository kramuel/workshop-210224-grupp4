using System;
using System.Collections.Generic;

namespace WorkShopV8
{
    class Player
    {

        private Deck _dealerDeck;
        private int _points;
        public List<Card> _playerHand;

        public Player(Deck deck, int points)
        {
            _points = points;
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
        public int playerValueofHand()
        {
            int sum = 0;
            foreach (Card card in _playerHand)
            {
                sum += card.value();
            }
            return sum;
        }
        public int playerPoints()
        {
            return _points;
        }
        public void addPoints(int bet)
        {
            _points += (bet * 2) - bet;
        }

    }
}
