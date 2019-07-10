using System;
using CustomClassListProject;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Adding an item to an empty list, item should go to index[0] (X)
        // Adding an item to a list with two items, item should go to index[2]
        // Adding an item to a list should increase count by 1
        // Adding an item to the list over capacity limit
        [Test]
        public void Add_AddToEmptyList_ValueGoesToIndexZero()
        {
            // arrange
            CustomClassList<int> test = new CustomClassList<int>();
            int expected = 10;
            int actual;

            // act
            test.Add(10);
            actual = test[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_AddToListWithTwoItems_ValueGoesToIndexTwo()
        {
            // arrange
            CustomClassList<int> test = new CustomClassList<int>();
            test.Add(1);
            test.Add(2);
            int expected = 8;
            int actual;

            // act
            test.Add(8);
            actual = test[2];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_AddToListWithTwoItems_CountGoesUpByOne()
        {
            // arrange
            CustomClassList<int> test = new CustomClassList<int>();
            test.Add(1);
            test.Add(2);
            int expected = 3;
            int count = 2;
            int actual;

            // act
            test.Add(3);
            actual = count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Indexer_GettingValueOfIndexNotExists_ThrowsError()
        {
            // Arrange
            CustomClassList<int> test = new CustomClassList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            int index;
            // Act
            index = test[5];
            // Assert
            
        }

        // [Test]
        // public void Add_AddItemOverCapacityLimit_ThrowsError()
        // {
        //     // arrange
        //     CustomClassList<int> test = new CustomClassList<int>();
        //     test.Add(1);
        //     test.Add(2s);
        //     test.Add(3);
        //     test.Add(4);
        //     test.Add(5);
        //     bool expected = true;
        //     bool actual;

        //     // act
        //     test.Add(6);
        //     actual = test.isOverCapacity;

        //     // assert
        //     Assert.AreEqual(expected, actual);
        // }

        // [Test]
        // public void Add_AddToEmptyList_CountGoesUpByOne()
        // {
        //     // arrange
        //     CustomClassList<int> test = new CustomClassList<int>();
        //     int expected = 1;
        //     int actual;

        //     // act
        //     test.Add(1);
        //     actual = test.Count();

        //     // assert
        //     Assert.AreEqual(expected, actual);
        // }

        // [Test]
        // public void Add_AddItemToListWithTwoItems_ResizedList()
        // {
        //     // arrange
        //     CustomClassList<int> test = new CustomClassList<int>();
        //     test.Add(1);
        //     test.Add(2);
        //     int expected = 3;
        //     int actual;

        //     // act
        //     test.Add(3);
        //     actual = test.Count();

        //     // assert
        //     Assert.AreEqual(expected, actual);
        // }
    }
}