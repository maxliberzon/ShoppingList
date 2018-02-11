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


            int size;
            int option;


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
            Console.WriteLine("Shopping List:");
            Console.WriteLine("");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }

            bool run = true;
            while (run == true)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Choose what you want to do.");
                Console.WriteLine("1) Remove  items from shopping list.");
                Console.WriteLine("2) Add items to your shopping list.");
                Console.WriteLine("3) View shopping list.");
                Console.WriteLine("4) Finsih shopping list.");

                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");

                    string[] temp = new string[items.Length - 1];

 
                    Console.WriteLine("What item do you want to remove?");
                    string remove = Console.ReadLine();
                    int j = 0;

                    Console.WriteLine("");

                    bool inArray = false;
                    int indexOfIitemToRemove = -1;
                    for (int i = 0; i < items.Length; i++)
                    {

                        if(remove == items[i])
                        {
                            inArray = true;
                            indexOfIitemToRemove = i;
                        }
                    }

                    if(inArray != true)
                    {
                        Console.WriteLine("That item does not exist in your list.");
                        continue;
                    }
                    
                    bool removed = false;
                    for (int i = 0; i < items.Length; i++)
                    {

                        if(indexOfIitemToRemove != i)
                        {
                            removed = true;
                            temp[j] = items[i];
                            j++;
                        }
                    }

                    

                    items = temp;

                }

                if (option == 2)

                {
                    Console.WriteLine("");
                    Console.WriteLine("");


                    string[] temp = new string[items.Length + 1];

                    for (int i = 0; i < items.Length; i++)
                    {
                        temp[i] = items[i];

                    }

                    
                 
                    Console.WriteLine("What item do you want to add?");

                    temp[temp.Length - 1] = Console.ReadLine();

                    items = temp;
                }

                if (option == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Shopping List");

                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.WriteLine(items[i]);
                    }


                }
                
                if (option == 4)
                {
                    run = false;
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("You finished your shopping cart.");
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter to exit your list.");
                }
            }



            Console.ReadKey();
        }
    }
}
