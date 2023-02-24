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

            deck.displayPack(1,52);

            //calling the shuffle methods 
        
            bool shuffle;
            
            //1 -- Fisher-Yates Shuffle
            shuffle = Pack.shuffleCardPack(1);

            //2 -- Riffle Shuffle
            shuffle = Pack.shuffleCardPack(2);

            //3 -- No shuffle 
            shuffle = Pack.shuffleCardPack(3);

            //first check is it shuffled
            if (shuffle)
            {
                //calling the deal methods to get the dealt cards

                //first getting a single card
                Card shuffledCard = new Card();

                shuffledCard = Pack.deal();

                //getting any ammount of cards 

                List<Card> shuffledDeck = new List<Card>();

                shuffledDeck = Pack.dealCard(10);    // here you can put any number between 1 and 52.
                                                     // I have given 10 for example

                //displaying the cards we got after shuffles

                deck.displayPack(1);

                deck.displayPack(1, 10);
            }
                
            Console.ReadLine();                  //halting the console to read the output
        }
    }
}
