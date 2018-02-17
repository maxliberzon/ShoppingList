using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace maxshoppinglist
{
    class MaxList
    {
        //this class should have an array of items
        //and a size, to know how many items we have
        //functions we need:
        //add function
        //remove function

        string[] items = new string[0];

        public void Add(string item)
        {
            string[] temp = new string[items.Length + 1];

            for (int i = 0; i < items.Length; i++)
            {

                temp[i] = items[i];

            }
        }

        public void Remove(string item)
        {
            string[] temp = new string[items.Length - 1];

            for (int i = 0; i < items.Length; i++)
            {

                temp[i] = items[i];

            }

        }


    }
}
