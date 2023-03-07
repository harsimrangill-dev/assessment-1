using assessment;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Display
    {


        //method 1 for displaying the full pack

        // calling with one value/ index
        public static void displayPack(int index, List<Card> p)
        {
            if (index >= 1 && index <= p.Count)
                Console.WriteLine("Your card is " + p[index - 1]);

            else if (p.Count == 0)
                throw new EmptyPackException("Your pack is Empty. Get a new pack.");

            else
                Console.WriteLine("Error irregular input. Index does not exist.");

        }



        //calling with range  
        //overloaded
        public static void displayPack(int start, int end, List<Card> p)
        {
            if ((start >= 1 && start <= p.Count) && (end >= 2 && end <= p.Count))
            {
                for (int i = start - 1; i < end; i++)
                    Console.WriteLine("Your card is " + p[i]);
            }

            else if (p.Count == 0)
                throw new EmptyPackException("Your pack is Empty. Get a new pack.");

            else
                Console.WriteLine("Error irregular input.Index does not exist.");

            
        }




        //calling with only one parameter but getiing range
        public static void DisplayPack(int start, List<Card> p)
        {
            if (start >= 1 && start <= p.Count)
            {
                for (int i = 0; i < start; i++)
                {
                    Console.WriteLine("Your card is " + p[i]);

                }
            }

            else if (p.Count == 0)
                throw new EmptyPackException("Your pack is Empty. Get a new pack.");

            else
                Console.WriteLine("Error irregular input.Index does not exist.");

        
        }

    }
}
