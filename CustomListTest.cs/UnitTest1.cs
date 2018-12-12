using System;
using System.Collections.Generic;
using System.Linq;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTest.cs
{
    [TestClass]
    public class UnitTest1
    {
        private int expectedResult;

        [TestMethod]
        public void AddMethodTest1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int expectedResult = 1;
            //Act
            myList.Add(value);
            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void AddMethodTest2()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int expectedResult = 1;
            //Act
            myList.Add(value);
            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void AddMethodTest3()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int value2 = 5;
            int expectedResult = 2;
            //Act
            myList.Add(value);
            myList.Add(value2);
            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void AddMethodTest4()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 3;
            int value2 = 5;
            int value3 = 5;
            int value4 = 5;
            int value5 = 5;
            int expectedResult = 5;
            //Act
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }

        [TestMethod]

        public void AddMethodTest5()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedResult = 11;
            //Act
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
            myList.Add(11);
            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void RemoveMethodTest1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 2;
            int expectedResult = 2;
            //Act
            myList.Add(value);
            myList.Add(1);
            myList.Add(2);
            myList.Remove(2);
            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }


        [TestMethod]
        public void RemoveMethodTest2()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 2;
            int value2 = 4;
            int expectedResult = 2;
            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Remove(4);
            myList.Remove(3);

            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }

        [TestMethod]
        public void RemoveMethodTest3()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 2;
            int value2 = 4;
            expectedResult = 3;
            //Act 
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Remove(5);
            myList.Remove(4);


            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }

        [TestMethod]
        public void RemoveMethod4()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 2;
            int value2 = 4;
            expectedResult = 1;
            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Remove(5);
            myList.Remove(4);
            myList.Remove(3);
            myList.Remove(2);

            //Assert
            Assert.AreEqual(1, myList.Count);
        }
        [TestMethod]
        public void RemoveMethod5() //failed test
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedResult = 3;
            //Act
            myList.Add(0);
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Remove(2);
            myList.Remove(1);
            myList.Remove(0);

            //Assert
            Assert.AreEqual(2, myList.Count);
        }
    }
}

[TestMethod]
public void ToStringMethod1()
{
    //Arrange
    CustomList<int> myList = new CustomList<int>();
    string expectedResult = "012";
    //Act
    myList.Add(0);
    myList.Add(1);
    myList.Add(2);
    string actualResult = myList.ToString();

    //Assert
    Assert.AreEqual(expectedResult, actualResult);
}


[TestMethod]
public void ToStringMethod2()
{
    //override string return with spaces and not commas
    //Arrange
    string<int> List = new myList<int>() { 1, 2, 3, 4, 5, 6 };
    string expectedResult = { 1 2 3 4 5 };
    string result;

    //Act
    result = myList.ToString();
    //Assert
    for (int i = 0; i < expectedResult.Count; i++)
    {
        Assert.AreEqual(Assert.AreEqual(result[i], expected[i]);
    }

    
   
}



[TestMethod]
public void ToStringMethod3()
{   //remove string from the list with bool

    //Arrange
    List<List<int>> list = new List<List<int>>()

    List<int> myList = new List<int>() { 1, 2, 3, 4, 5 };
    bool result;

    //Act
    list.Add(myList);
    result = list.Remove(myList);

    //Assert
    Assert.IsTrue(result);
}

[TestMethod]
public void ToStringMethod4()
    //override string 
    List<int> list = new List<int>() {1, 2, 3, 4};
{    //Arrange
    string expected = "1. 2. 3. 4.";
    string result;
    //Act
    result = List.ToString();
    //Assert
    Assert.AreEqual(result);
}

[TestMethod]
public void ToStringMethod5()
{
    //Arrange

    //Act

    //Assert
}

[TestMethod]
//public void ZipMethod1()
{
    //Arrange
    //zip two lists together and return 6
    List<int> even = new List<int>() { 2, 4, 6, 8 };
    List<int> odd = new List<int>() { 1, 3, 5, 7 };
    List<int> myZipList;
    int expectedResult = 6;
    
    //Act
    myZipList = odd.Zip(odd);
    result =myZipList.Count;

    //Assert
    Assert.AreEqual(expectedResult, actualResult);
}


[TestMethod]
public void ZipMethod2()
{ //zip together the two lists and return a new list
  //Arrange
       List<int> even = new List<int>() { 2, 4, 6, 8 };
       List<int> odd = new List<int>() { 1, 3, 5, 7 };
       List<int> expectedResult = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8 };
       List<int> result;
    //Act
    result = odd.Zip(even);


    //Assert
    for (int i = 0; i <expectedResult.Count; i++)
    {
        Assert.AreEqual(result[i], expectedResult[i]);
    }

}

[TestMethod]
public void ZipMethod3()
{
    //Arrange

    //Act

    //Assert

}

[TestMethod]
public void ZipMethod4()
{
    //Arrange

    //Act

    //Assert

}

[TestMethod]
public void ZipMethod5()
{
    //Arrange

    //Act

    //Assert
}

[TestMethod]
public void OverloadOperatorAddMethod1()
add the two lists and combine them

{   //Ararnge
    List<int> list1 = new List<int>() { 10, 20, 30 };
List<int> list2 = new List<int>() { 40, 50, 60 };
List<int> expected = new List<int>() { 10, 20, 30, 40, 50, 60 };
List<int> result;
Act
result = list1 + list2;
Assert
    for (int i = 0; i<expected.Count; i++)
    {
        Assert.AreEqual(result[i], expected[i]);
    }
}




        [TestMethod]
public void OverloadOperatorAddMethod2()
{
    //Arrange

    //Act


    //Assert


}
[TestMethod]
public void OverloadOperatorAddMethod3()
{
    //Arrange

    //Act

    //Assert

}

[TestMethod]
public void OverloadOperatorAddMethod4()
{
    //Arrange

    //Add

    //Assert

}
[TestMethod]
public void OverloadOperatorAddMethod5()
{
    //Arrange

    //Add

    //Assert
}

[TestMethod]
public void OverloadOperatorSubtractMethod1()
{
    //Arrange

    //Act

    //Assert

}

//[TestMethod]
//public void OverloadOperatorSubtractMethod2()
//{
//    //Arrange

//    //Act

//    //Assert

//}

//[TestMethod]
//public void OverloadOperatorSubtractMethod3()
//{
//    //Arrange

//    //Act

//    //Assert

//}

//[TestMethod]
//public void OverloadOperatorSubtractMethod4()
//{
//    //Arrange

//    //Act

//    //Assert


//}

//[TestMethod]
//public void OverloadOperatorSubtractMethod5()
//{

//    //Arrange

//    //Act

//    //Assert

//}
//  }
//}
