using Microsoft.Win32;
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

            deck.displayPack(1,52,deck.pack);

            //calling the shuffle methods 

            int run = 0;    

            bool shuffle = false;   //intailizing in case of exception.
            while (true)
            {
                try
                {

                    Console.WriteLine("what type of shuffle you want ?\n\t\t 1 -- Fisher Yates " +
                        "\n\t\t 2 -- Riffle Shuffle \n\t\t 3 -- No shuffle.");

                    int type = Convert.ToInt32(Console.ReadLine());

                    if (type < 1 || type > 3)
                        throw new ArgumentOutOfRangeException("Input out of range");

                    else if (type == 1)
                    {
                        shuffle = Pack.shuffleCardPack(1);
                        run++;
                        break;
                    }

                    else if (type == 2)
                    {
                        shuffle = Pack.shuffleCardPack(2);
                        run++;
                        break;
                    }
                    else
                    {
                        shuffle = Pack.shuffleCardPack(3);
                        run++;
                        break;
                    }
                    
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("You should only provide numeric input.");
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }


            while (true)
            {
                //first check is it shuffled
                if (shuffle)
                {

                    try
                    {
                        Console.WriteLine("How many cards do you want?..");

                        int amount = Convert.ToInt32(Console.ReadLine());

                        if (amount < 1 || amount > 52)
                            throw new IndexOutOfRangeException("Index out of range");

                        else if (amount == 1)
                        {
                            Card shuffledCard = new Card();

                            shuffledCard = Pack.deal();

                            Console.WriteLine(shuffledCard.ToString());
                            break;
                        }

                        else
                        {


                            //getting any ammount of cards 

                            List<Card> shuffledDeck = new List<Card>();

                            shuffledDeck = Pack.dealCard(amount);

                            deck.DisplayPack(amount, shuffledDeck);
                            break;
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }

                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Error you cannot give this input.");
                        continue;
                    }


                }
                else if (run == 0)
                    Console.WriteLine("\n");
                else
                {
                    Console.WriteLine("It seems your deck is not shuffled");
                }
            }
            

            Console.ReadLine();                  //halting the program.
        }
    }
}
