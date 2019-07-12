using System;
using CustomClassListProject;
using NUnit.Framework;
using FluentAssertions;

namespace Tests
{
    public class RemoveTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        // Removing an item should decrease count by one
        // Removing an item should remove it and shift the remainder items in the list
        // Removing an item, if list contains the item should return true 
        // Removing an item, if list doesn't contain the item should return false
        [Test]
        public void Remove_RemoveAnItemFromList_CountDecreasesByOne()
        {
            // arrange
            CustomClassList<int> test = new CustomClassList<int>();
            test.Add(0);
            test.Add(1);
            test.Add(2);
            int expected = 2;
            int actual;

            // act
            test.Remove(2);
            actual = test.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Remove_ListContainsTheItem_ReturnsTrue()
        {
            // arrange
            CustomClassList<int> test = new CustomClassList<int>();
            test.Add(0);
            test.Add(1);
            test.Add(2);
            bool expected = true;
            bool actual;

            // act
            actual = test.Remove(2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Remove_ListDoesNotContainTheItem_ReturnsFalse()
        {
            // arrange
            CustomClassList<int> test = new CustomClassList<int>();
            test.Add(0);
            test.Add(1);
            test.Add(2);
            bool expected = false;
            bool actual;

            // act
            actual = test.Remove(3);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Remove_RemoveItemFromTheList_ShiftsRemainderItemsAccordingly()
        {
            // arrange
            CustomClassList<int> test = new CustomClassList<int>();
            test.Add(0);
            test.Add(1);
            test.Add(2);
            int expected = 1;
            int actual;

            // act
            test.Remove(0);
            actual = test[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}