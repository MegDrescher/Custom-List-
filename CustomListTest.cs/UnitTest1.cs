using System;
using System.Collections.Generic;
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
            Assert.AreEqual(expectedResult, myList.Count);
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
            Assert.AreEqual(expectedResult, myList.Count);
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
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void ToStringMethod3()
        {
            //Arrange

            //Act

            //Assert

        }

        [TestMethod]
        public void ToStringMethod4()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void ToStringMethod5()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void ZipMethod1()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void ZipMethod2()
        {
            //Arrange

            //Act

            //Assert

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
        {   //Ararnge

            //Act

            //Assert

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

        [TestMethod]
        public void OverloadOperatorSubtractMethod2()
        {
            //Arrange

            //Act

            //Assert

        }

        [TestMethod]
        public void OverloadOperatorSubtractMethod3()
        {
            //Arrange

            //Act

            //Assert

        }

        [TestMethod]
        public void OverloadOperatorSubtractMethod4()
        {
            //Arrange

            //Act

            //Assert


        }

        [TestMethod]
        public void OverloadOperatorSubtractMethod5()
        {

            //Arrange

            //Act

            //Assert

        }
    }
}
