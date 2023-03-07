using CMP1903M_A01_2223;
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

            Display.displayPack(1,52,deck.pack);

            //calling the shuffle methods 

            int run = 0;    

            bool shuffle = false;   //intailizing in case of exception.
            while (true)
            {
                try
                {

                    Console.WriteLine("what type of shuffle you want ?\n\t\t 1 -- Fisher Yates " +
                        "\n\t\t 2 -- Riffle Shuffle \n\t\t 3 -- No shuffle.");

                    string tp = Console.ReadLine();

                    int type = Convert.ToInt32(tp);

                    if (type < 1 || type > 3)
                        throw new ArgumentOutOfRangeException("Input out of range");

                    else if (type == 1)
                    {
                        shuffle = Pack.shuffleCardPack(1);
                        run++;
                        
                    }

                    else if (type == 2)
                    {
                        shuffle = Pack.shuffleCardPack(2);
                        run++;
                        
                    }
                    else
                    {
                        shuffle = Pack.shuffleCardPack(3);
                        run++;
                        
                    }

                    Console.WriteLine("\n Do you wish to shuffle one more time... \n\t\t Y/N..");

                    char ans = (char)Console.Read();

                    if (ans == 'Y' || ans == 'y')
                    {
                        tp = Console.ReadLine();

                        continue;
                    }
                    else if (ans == 'n' || ans == 'N')
                    {
                        break;
                    }
                    else
                        throw new InputException("Please Enter a valid y/n");




                }
                catch (InputException e)
                {
                    Console.WriteLine(e.Message);
                    continue;

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
            int count = 1;

            while (true)
            {
                //first check is it shuffled
                if (shuffle)
                {

                    try
                    {
                        Console.WriteLine("How many cards do you want?..");

                        string amt = Console.ReadLine();
                        if (count != 0)
                            amt = Console.ReadLine();

                        int amount = Convert.ToInt32(amt);

                        if (amount < 1 || amount > 52)
                            throw new IndexOutOfRangeException("Index out of range");

                        else if (amount == 1)
                        {
                            Card shuffledCard = new Card();

                            shuffledCard = Pack.deal();

                            Console.WriteLine(shuffledCard.ToString());
                            count++;
                        }
                        else
                        {


                            //getting any ammount of cards 

                            List<Card> shuffledDeck = new List<Card>();

                            shuffledDeck = Pack.dealCard(amount);

                            Display.DisplayPack(amount, shuffledDeck);
                            count++;

                        }

                        Console.WriteLine("\n Do you wish to get more Cards... \n\t\t Y/N..");

                        char s = (char)Console.Read();
                        
                        if (s == 'Y' || s == 'y')
                        {
                            

                            continue;
                        }
                        else if (s == 'n' || s == 'N')
                        {
                            break;
                        } 
                        else
                            throw new InputException("Please Enter a valid y/n");

                    }
                    catch (InputException e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }

                    catch (EmptyPackException e)
                    {
                        Console.WriteLine(e.Message);
                        break;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }

                    catch (IndexOutOfRangeException e)
                    {
                        count = 0;
                        Console.WriteLine(e.Message);
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
