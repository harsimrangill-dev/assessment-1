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

            bool shuffle = false;   //intailizing in case of exception.

            try
            {        

                Console.WriteLine("what type of shuffle you want ?\n\t\t 1 -- Fisher Yates " +
                    "\n\t\t 2 -- Riffle Shuffle \n\t\t 3 -- No shuffle.");

                int type = Convert.ToInt32(Console.ReadLine());

                if (type < 1 || type > 3)
                    throw new Exception();

                else if (type == 1)
                    shuffle = Pack.shuffleCardPack(1);

                else if (type == 2)
                    shuffle = Pack.shuffleCardPack(2);

                else
                    shuffle = Pack.shuffleCardPack(3);
            }

            catch
            {
                Console.WriteLine("Invalid input try again.");
            }

            

            //first check is it shuffled
            if (shuffle)
            {

                try
                {
                    Console.WriteLine("How many cards do you want?..");

                    int amount = Convert.ToInt32(Console.ReadLine());

                    if (amount < 1 || amount > 52)
                        throw new Exception();

                    else if (amount == 1)
                    {
                        Card shuffledCard = new Card();

                        shuffledCard = Pack.deal();

                        Console.WriteLine(shuffledCard.ToString());
                    }

                    else
                    {
                        

                        //getting any ammount of cards 

                        List<Card> shuffledDeck = new List<Card>();

                        shuffledDeck = Pack.dealCard(amount);

                        deck.DisplayPack(amount);
                    }
                }

                catch
                {
                    Console.WriteLine("Error you cannot give this input.");
                }                


            }
            else
            {
                Console.WriteLine("It seems your deck is not shuffled");
            }

            

            Console.ReadLine();                  //halting the program.
        }
    }
}
