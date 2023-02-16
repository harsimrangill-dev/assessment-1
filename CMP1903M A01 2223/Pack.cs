using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        //intializing the empty pack
        // Creating a list of 'card' objects to create a 'pack of cards'
        // this is a collection of 'card'  
        public List<Card> pack  = new List<Card>();

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
                    pack.Add(new Card());        //creating a empty card object
                    
                    pack[count].Suit = (Card.suit)i;   // assisgn value to one member   variable
                    
                    pack[count].Value = j;              // assisgn value to second member variable
                    
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

                //initating the main for loop
                for (int i = 0; i <= 51; i++) 
                {
                                      
                    int count = rnd.Next(i, 52) ;            //variable to hold the ramdomly generated number

                    Card exchange= new Card();           // intermidiate variable for containing the value during exchange

                    pack[count] = exchange;
                }
            }

        }
        //public static Card deal()
        //{
            //Deals one card

        //}
       // public static List<Card> dealCard(int amount)
        //{
            //Deals the number of cards specified by 'amount'
        //}
    }
}
