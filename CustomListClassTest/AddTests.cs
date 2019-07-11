using System;
using CustomClassListProject;
using NUnit.Framework;
using FluentAssertions;

namespace Tests
{
    public class AddTests
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
            int actual;

            // act
            test.Add(3);
            actual = test[2];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_AddItemsToListMoreThanCurrentCapacity_CapacityIncreases()
        {
            // arrange
            CustomClassList<int> test = new CustomClassList<int>();
            test.Add(0);
            test.Add(1);
            test.Add(2);
            test.Add(3);
            int expected = 8;
            int actual;

            // act
            test.Add(4);
            actual = test.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_AddItemsToListMoreThanCurrentCapacity_GoesToNextIndex()
        {
            // arrange
            CustomClassList<int> test = new CustomClassList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            int expected = 5;
            int actual;

            // act
            test.Add(5);
            actual = test[4];

            // assert
            Assert.AreEqual(expected, actual);
        }

        // // This is what I did instead of that
        // [Test]
        // public void Indexer_GettingValueOfIndexNotExists_ThrowsError()
        // {
        //     // Arrange
        //     CustomClassList<int> test = new CustomClassList<int>();
        //     test.Add(0);
        //     test.Add(1);
        //     test.Add(2);
        //     test.Add(3);

        //     // Act
        //     Action act = () => test.Add(4);

        //     // Assert
        //     act.Should().Throw<ArgumentOutOfRangeException>();
        // }

        // [Test]
        // public void Add_AddItemOverCapacityLimit_ThrowsError()
        // {
        //     // arrange
        //     CustomClassList<int> test = new CustomClassList<int>();
        //     test.Add(1);
        //     test.Add(2);
        //     test.Add(3);
        //     test.Add(4);

        //     // act
        //     Action act = () => test.Add(5);

        //     // assert
            
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