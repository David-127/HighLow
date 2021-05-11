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
            int points = 0;
            drawDeck();

            
                

            for (int j = 0; j< 2; j++)
            {



                for (int i = 0; i < 13; i++)
                {

                    Console.Clear();
                    value card1 = drawCard();
                    try
                    {
                        int choose;
                        while (true)
                        {



                            Console.WriteLine("Total points: " + points);
                            Console.WriteLine("TYPE 1 to select LOW");
                            Console.WriteLine("TYPE 2 to HIGH");
                            Console.WriteLine("TYPE 3 to END GAME");

                            choose = int.Parse(Console.ReadLine());

                            if (choose > 3 || choose < 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Please choose a valid option");
                            }
                            else
                            {
                                break;
                            }
                        }



                        switch (choose)
                        {

                            case 1:

                                var newCard = drawCard();
                                if (newCard > card1)
                                {
                                    Console.WriteLine("Wrong no Points");
                                }
                                else if(newCard == card1)
                                {
                                    Console.WriteLine("You got pair , You lose");
                                    Console.ReadLine();
                                    break;
                                }
                                else if(newCard == value.Ace)
                                {
                                    Console.WriteLine("ACE both LOW and HIGH");
                                    Console.ReadLine();
                                    points++;
                                }
                                else
                                {
                                    points++;
                                }
                                card1 = newCard;
                                break;


                            case 2:
                                var newCard2 = drawCard();
                                if (newCard2 < card1)
                                {
                                    Console.WriteLine("Wrong no Points");
                                }
                                else if(newCard2 == card1)
                                {
                                    Console.WriteLine("You got pair , You lose");
                                    Console.ReadLine();
                                    break;
                                }
                                else if (newCard2 == value.Ace)
                                {
                                    Console.WriteLine("ACE both LOW and HIGH");
                                    Console.ReadLine();
                                    points++;
                                }
                                else
                                {
                                    points++;
                                    Console.WriteLine("Total points: " + points);
                                }
                                card1 = newCard2;
                                break;

                            case 3:
                                Environment.Exit(0);
                                break;
                        }

                    }
                    catch
                    {
                        Console.WriteLine("Incorrect input try again");
                    }


                }
                Console.WriteLine("\n\nTotal points: " + points);
                Console.ReadLine();

            }
            Console.WriteLine("\n\nGame finishied, total point: " + points);
            Console.WriteLine("Please ENTER YOUR NAME:");
            string name = Console.ReadLine();
            int score = points;
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
            Console.WriteLine(cardNumber);

            var cardVal = deck[cardNumber].getCardValue();
            var cardSuit = deck[cardNumber].getCardSuit();

            Console.WriteLine(cardVal + " of " + cardSuit);

            deck.RemoveAt(cardNumber);

            return cardVal;

        }


        
           }

        }

    

