using System;
using System.Collections.Generic;

namespace HighLow
{
    public enum color { Black, Red }
    public enum value
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public enum suit
    {
        Hearts,
        Spades,
        Diamond,
        Club
    }
    class Program
    {
        static List<Card> deck = new List<Card>();
        static void Main(string[] args)
        {
            


            bool playing = true;
            while (playing == true)
            {
                int points = 0;
                Console.Clear();
                drawDeck();
                drawCard();
                cardChooser();
                Console.ReadLine();
            }


        }

        static void drawDeck()
        {
            deck.Clear();

            for (int i = 0; i < 13; i++)
            {
                deck.Add(new Card((value)i, suit.Club));
                deck.Add(new Card((value)i, suit.Diamond));
                deck.Add(new Card((value)i, suit.Hearts));
                deck.Add(new Card((value)i, suit.Spades));

            }
        }
        static value drawCard()
        {
            Random rnd = new Random();
            var cardNumber = rnd.Next(0, deck.Count);
            var cardVal = deck[cardNumber].getCardValue();
            var cardSuit = deck[cardNumber].getCardSuit();

            Console.WriteLine(cardVal + " of " + cardSuit);

            deck.RemoveAt(cardNumber);

            return cardVal;

        }

        static void cardChooser()
        {
            Console.WriteLine("Press 1 to select LOW");
            Console.WriteLine("Press 2 to HIGH");
            Console.WriteLine("Press 3 to END GAME");
                var chooseCard = 0;

            switch (chooseCard)
            {

                case 0:

                    break;

                case 1:
                    break;

                case 2:
                        Environment.Exit(0);
                    break;
            }
            }

        }

    }

