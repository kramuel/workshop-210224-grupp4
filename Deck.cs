using System;
using System.Collections.Generic;

namespace WorkShopV8
{
    class Deck
    {
        public List<Card> _deck;

    
        public Deck(){

            _deck = new List<Card>();
            
            for (var i = 2; i <= 13; i++)
            {
                _deck.Add(new Card("Hearts", i, false));
            }
            _deck.Add(new Card("Hearts", 14, true));

            for (var i = 2; i <= 13; i++)
            {
                _deck.Add(new Card("Clubs", i, false));
            }
            _deck.Add(new Card("Clubs", 14, true));

            for (var i = 2; i <= 13; i++)
            {
                _deck.Add(new Card("Spades", i, false));
            }
            _deck.Add(new Card("Spades", 14, true));

            for (var i = 2; i <= 13; i++)
            {
                _deck.Add(new Card("Diamonds", i, false));
            }
            _deck.Add(new Card("Diamonds", 14, true));
            
        }


        public void PrintDeck() {
            foreach (Card card in _deck)
            {
                card.PrintCard();
            }
        }
    }
}
