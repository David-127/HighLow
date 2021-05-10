using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Card
    {
        //fält
        value cardValue;
        suit cardSuit;

        //konstruktor
        public Card(value cardValue, suit cardSuit)
        {
            this.cardValue = cardValue;
            this.cardSuit = cardSuit;
        }
        //metoder
        public void CardInfo()
        {

        }
        public void setCardValue(value cardValue)
        {
            this.cardValue = cardValue;
        }

        public value getCardValue()
        {
            return cardValue;
        }

        public void setCardSuit(suit cardSuit)
        {
            this.cardSuit = cardSuit;
        }

        public suit getCardSuit()
        {
            return cardSuit;
        }

    }
}
