using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        public int Capacity;

        T[] items;
        private int count;
        public int Count { get { return count; } }

        public CustomList()
        {
            Capacity = 4;
            items = new T[Capacity];
            count = 0;
        }


        public void Add(T value)
        {
            if (count == Capacity)
            {
                // make a bigger temp array
                Capacity *= 2;
                T[] tempArray = new T[Capacity];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];
                }
                items = tempArray;
            }

            count++;
            items[Count - 1] = value;
        }

    }   






            //if(Count == 0)
            //{
            //    count++;
            //}
            //T[] tempArray = new T[Count + 1];
            //for (int i = 0; i < Count; i++)
            //{
            //    tempArray[i] = items[i];
            //}
            //count++;
            //tempArray[Count] = value;
            //items = tempArray;

            
              
        }


        //Use a private void temporary array (private void T[] tempArray = new T[];
        //That reassigns back to the member variable array to keep track of what is added
        //Make sure the .Count goes up by 1 each time something is added to the list.
        //First AddTestMethod, use items [] = item
        //items = tempArray; would be the last thing used in the add method, resizing the Array
     
        ////List<int> list = new List<int>(new int[]{ 2, 3, 7 });
        //// Loop with for and use string interpolation to print values.
        //for (int i = 0; i<list.Count; i++)
        //{
        //    Console.WriteLine($"{i} = {list[i]}");
        //}

        //public void Remove(int v)
        //{
        //    throw new NotImplementedException();
        //}

        //private void Add(T items)
        //{

        //}
        ////    private void Add(T items)
        //{
        //    T[] tempArray = new T[];
        //    items[] = items; 
        //    items = tempArray
        //      for loop




        //public bool Remove(T item)
        //{
        //    //write logic to remove item from items
        //    return true;
        //}

        //public override string ToString()
        //{
        //    return "";
        //}
    
