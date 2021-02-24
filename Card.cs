using System;

namespace WorkShopV8
{
    class Card
    {
        private string _suit;
        private int _value;
        private bool _ace;

        public Card(string suit, int value, bool ace)
        {
            _suit = suit;
            _value = value;
            _ace = ace;
        }

        public void PrintCard(){
            System.Console.WriteLine($"{_value} of {_suit} ");
        }
    }
    // enum Suits
    // {
    //     Hearts,Clubs,Diamonds,Spades
    // }
}
