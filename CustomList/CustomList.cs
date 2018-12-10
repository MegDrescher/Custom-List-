using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        T[] items = new T[1];

        //use the get set

        //Use a private void temporary array (private void T[] tempArray = new T[];
        //That reassigns back to the member variable array to keep track of what is added
        //Make sure the .Count goes up by 1 each time something is added to the list.
        //First AddTestMethod, use items [] = item
        //items = tempArray; would be the last thing used in the add method, resizing the Array

        public void Add(T item)
        {
            T[] tempArray = new T[];
            int[] myList = new int[1];
            for (int value = 0; value < 3; value++)
            {
                int expectedResult = 0;
                myList[value] = expectedResult;
            }

        }

        //private void Add(T items)
        //{

        //}
        ////    private void Add(T items)
        //{
        //    T[] tempArray = new T[];
        //    items[] = items; 
        //    items = tempArray
        //      for loop




        public bool Remove(T item)
        {
            //write logic to remove item from items
        }

        public override string ToString()
        {
            return "";
        }
    }
}
