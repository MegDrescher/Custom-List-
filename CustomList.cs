using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
//Use a private void temporary array (private void T[] tempArray = new T[];
//That reassigns back to the member variable array to keep track of what is added
//Make sure the .Count goes up by 1 each time something is added to the list.
//First AddTestMethod, use items [] = item
//items = tempArray; would be the last thing used in the add method, resizing the Array

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

        public bool Remove(T value)

        {
            if (count == Capacity)
            {
                //make a bigger temp array
                Capacity *= 2;
                T[] tempArray = new T[Capacity];
                for(int i = 0; i < count; i ++)
                {
                    tempArray[i] = items[i];
                }
                items = tempArray;
            }


        }
    }

    
}
    

      
        
  
































































































































