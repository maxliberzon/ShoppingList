using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxshoppinglist
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user to enter a size
            //store this into a variable
            //then make a string array that is as big as the user asked for
            //EX: user enters 5, make a 5 long array
            //once we have this array, ask the user to enter the items that they want, and store each one into the array

            int size;
            


            Console.WriteLine("Enter a size.");

            size = int.Parse(Console.ReadLine());

            string[] items = new string[size];

            Console.WriteLine("Enter the items that you want.");
            

            for (int i = 0; i < items.Length; i++)
            {
                Console.Write("item: ");
                items[i] = Console.ReadLine();

                
            }

            Console.WriteLine("");

           for(int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }


            Console.ReadKey();
        }
    }
}
