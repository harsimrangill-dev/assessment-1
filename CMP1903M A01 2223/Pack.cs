using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    class Pack
    {
        //intializing the empty pack
        // Creating a list of 'card' objects to create a 'pack of cards'
        // this is a collection of 'card'  

        private static List<Card> _pack  = new List<Card>();        //private

        //properties
        public List<Card> pack
        {
            get { return _pack; }       //only get means this is a read only property
        }
            
        //pack constructor

        public Pack()
        {
            //Initialise the card pack here

            //intializing the count variable to keep track of the collection
            int count = 0;
            
            //defining the for loop and nested loop
            for (int i = 1; i <= 4; i++)
            {
                
                for (int j = 1; j <= 13; j++)
                {
                    _pack.Add(new Card());        //creating a empty card object
                    
                    _pack[count].suit = (Card.Suit)i;   // assisgn value to one member   variable
                    
                    _pack[count].Value = j;              // assisgn value to second member variable
                    
                    count++;        // incrimenting the counter for the list         
                }
                //error handling just  in case 
                if (count == 53)
                {
                    break;
                }
            }
            
        }



        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle

            //identifying the type of shuffle requried by the user

            if (typeOfShuffle == 1)                 //Fisher-Yates Shuffle
            {

                //creating a random object
                Random rnd = new Random();

                Card exchange = new Card();           // intermidiate variable for containing the value during exchange

                //initating the main for loop
                for (int i = 0; i <= 51; i++)
                {
                    int randomNum = rnd.Next(i, 52);            //variable to hold the ramdomly generated number

                    exchange = _pack[randomNum];
                    _pack[randomNum] = _pack[i];
                    _pack[i] = exchange;

                }
                //returning the value
                return true;
            }

            //second shuffle --- Riffle Shuffle
            else if (typeOfShuffle == 2)
            {
                // creating two new list to contain the halfed pack list

                List<Card> firstHalf = new List<Card>();

                List<Card> secondHalf = new List<Card>();

                for (int i = 0; i <= 25; i++)
                {
                    firstHalf.Add(_pack[i]);                     // inserting the first half into the list

                    secondHalf.Add(_pack[26 + i]);                  // inserting the second half
                }
                //defining the loop for shuffling 
                for (int i = 0; i <= 25; i++)
                {
                    _pack[2 * i] = firstHalf[i];      // first element from first half

                    _pack[2 * i + 1] = secondHalf[i];   //second element from second half
                }
                _pack.Reverse();  //reversing order to create perfect shuffle

                return true;
            }
            else if (typeOfShuffle == 3)
            {
                return true;
            }
            else
                // in case there is an error or unexpected input
                Console.WriteLine("Invalid input. Please enter a valid input to shuffle the cards.");
                return false;      
        }
        public static Card deal()
        {
            //Deals one card           
            return _pack[0];

        }
        public static List<Card> dealCard(int amount)
        {

            //Deals the number of cards specified by 'amount'

            // creating a list that is going to return wothout modifying the static list pack

            List<Card> cardDeal = new List<Card>();

            //for loop for adding the elemnets to the carddeal list
            for (int i = 0; i < amount; i++)
            {
                cardDeal.Add(_pack[i]);
            }
            return cardDeal;
        }
        
        
        
        
        
        //adding a display pack method 
 
        // calling with one value/ index
        public void displayPack(int index)
        {
            if (index >= 1 && index <= 52)
                Console.WriteLine("Your card is " + _pack[index - 1]);
            else
                Console.WriteLine("Error irregular input. Index does not exist.");
        }




        //calling with range
        public void displayPack(int start, int end)
        {
            if ((start >= 1 && start <= 51) && (end >= 2 && end <= 52))
            {
                for (int i = start - 1; i < end; i++)
                    Console.WriteLine("Your card is " + _pack[i]);
            }
            else
                Console.WriteLine("Error irregular input.Index does not exist.");
        }
        
        //overloaded method

        public void  DisplayPack(int start)
        {
            if (start >= 1 && start <= 51)
            {
                for( int i = 0; i < start; i++)
                {
                    Console.WriteLine("Your card is " + _pack[i]);

                }
            }
            else
                Console.WriteLine("Error irregular input.Index does not exist.");
        }

    }
}
