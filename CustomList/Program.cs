using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int value2 = 5;
            int expectedResult = 2;
            //Act
            myList.Add(value);
            myList.Add(value2);
            myList.Add(4);
            myList.Add(8);
            myList.Add(78);



            CustomList<int> myList2 = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.Add(9);
            myList.Add(10);

        }
    }
}
