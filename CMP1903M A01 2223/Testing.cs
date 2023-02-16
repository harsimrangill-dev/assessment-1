using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    class Testing
    {
        static void Main(string[] args)
        {
            //creating a pack object

            Pack deck = new Pack();

            //displaying the pack of cards to show that it is not tempered and is legit 
            for (int i = 0; i <= 51; i++)
             {
               Console.WriteLine(" {0} of  {1}",deck.pack[i].Value, deck.pack[i].Suit);
            }

            //calling the shuffle methods 

            //as all shuffle method returns a boolean value we have to first define it
            bool shuffle;

            //since the shuffle method is static we can directly call it without its object
            
            //1 -- Fisher-Yates Shuffle
            shuffle = Pack.shuffleCardPack(1);

            //2 -- Riffle Shuffle
            shuffle = Pack.shuffleCardPack(2);

            //3 -- No shuffle 
            shuffle = Pack.shuffleCardPack(3);

            //calling the deal methods to get the dealt cards

            //first getting a single card
            Card shuffledCard = new Card();

            shuffledCard = Pack.deal();
            
            //displaying its value
            Console.WriteLine("Your Card is {0} of {1}",shuffledCard.Value, shuffledCard.Suit);

            //getting any ammount of cards 

            List<Card> shuffledDeck = new List<Card>(); 
            
            shuffledDeck = Pack.dealCard(10);           // here you can put any number between 1 and 52. I have given 10 for example
            
            //displaying the cards we ggot from the function

            for (int i = 0; i <= 9; i++)
            {

                Console.WriteLine("{0} of {1}", shuffledDeck[i].Value, shuffledDeck[i].Suit);
            }
                
            Console.ReadLine();                  //halting the console to read the output
        }
    }
}
