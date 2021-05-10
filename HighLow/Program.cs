using System;
using System.Collections.Generic;

namespace HighLow
{
    public enum color { Black, Red }
    public enum value
    {
        Ace,
        Two ,
        Three ,
        Four ,
        Five,
        Six,
        Seven ,
        Eight ,
        Nine ,
        Ten ,
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
            int points = 0;
             while (playing ==true)
             {
              
            Console.Clear();
               drawDeck();
               var card1 = drawCard();
                try
                {
                    Console.WriteLine("TYPE 1 to select LOW");
                    Console.WriteLine("TYPE 2 to HIGH");
                    Console.WriteLine("TYPE 3 to END GAME");


                    int choose = int.Parse(Console.ReadLine());

                    switch (choose)
                    {

                        case 1:
                            
                            var newCard = drawCard();
                            if (newCard > card1)
                            {
                                Console.WriteLine("Wrong no Points");
                                Console.ReadLine();
                            }
                            else
                            {
                                points++;
                            }
                            break;


                        case 2:
                            var newCard2 = drawCard();
                            if (newCard2 < card1)
                            {
                                Console.WriteLine("Wrong no Points");
                                Console.ReadLine();
                            }
                            else
                            {
                                points++;
                            }
                            break;

                        case 3:
                            Environment.Exit(0);
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect input try again");
                    Console.ReadLine();
                }

                if(playing == false)
                {
                    Console.WriteLine("Your Score Was: " + points + "\n  PLEASE enter your name!");
                    Console.ReadLine();
                }

                Console.WriteLine(deck.Count);
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


        
           }

        }

    

