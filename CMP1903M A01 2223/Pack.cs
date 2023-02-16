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
        // this is a collection of 'card'  
        public List<Card> pack  = new List<Card>();

        public Pack()
        {
            //Initialise the card pack here
            // Creating a list of 'card' objects to create a 'pack of cards'


            //defining the for loop and nested loop
            //intializing the count variable to keep track of the collection

            int count = 0;
            for (int i = 1; i <= 4; i++)
            {
                
                for (int j = 1; j <= 13; j++)
                {
                    pack.Add(new Card());        //creating a empty card object
                    
                    pack[count].Suit = (Card.suit)i;   // assisgn value to one member   
                    
                    pack[count].Value = j;              // assisgn value to second variable
                    
                    count++;        // incrimenting the counter for the list         
                }
                //error handling in case 
                if (count == 53)
                {
                    break;
                }
            }
            
        }

        

        //public static bool shuffleCardPack(int typeOfShuffle)
        //{
            //Shuffles the pack based on the type of shuffle

        //}
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
