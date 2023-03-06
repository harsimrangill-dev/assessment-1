using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    class Card
    {
        //Base for the Card class.

        // defining a special type for Suit of the Cards with base integer
        public enum Suit
        {
            Spades = 1,       // intializing the first at 1 othervise it would be 0
            Diamonds,
            Hearts,
            Clubs
        }

        //constructor
        public Card()
        {
            _suit = 0;  //intializing fileds

            _value = 0;
        }


        //defining private variables

        private int _value;
        private Suit _suit;

        //properties
        //Value: numbers 1 - 13

        public int Value
        {
            get { return _value; }

            //set condions to only assign legal values
            set { if ((value >= 1) && (value <= 13))
                    _value = value;
                  else
                    Console.WriteLine("Sorry cannot assign this value to the card.Please provide a legal value");
            } 
        }

       

        //Suit: enum suit 1 - 4

        public Suit suit
        {
            get { return _suit; }
            
            //set contadions to stop assign non legal values 
            set { if (((int)value >= 1 ) && ((int)value <= 4))
                    _suit = value;
                  else
                    Console.WriteLine("sorry can not assisgn a proper suit to the card. plesase provide an acceptable value");
            }
        }

        //overeride method to display card value by default

        public override string ToString()
        {      
                switch (_value)
                {
                    case 11:
                        return "Jack of " + suit.ToString();

                    case 12:
                        return "Queen of " + suit.ToString();

                    case 13:
                        return "King of " + suit.ToString();

                    case 1:
                        return "Ace of " + suit.ToString();

                    default:
                        return Value.ToString() + " of " + suit.ToString();

                }

        }




    }
}
