using System;
using NUnit.Framework;
using CustomClassListProject;
using FluentAssertions;

namespace Tests
{
    public class PlusOperatorTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        // Adding two customlists together, result list's first index should be the first item in the first list
        // Adding two customlists together, result list's last index should be the last index of the second list
        // Adding two customlists with two items in each together, result list's [2] item must be the second list's first index
        // Adding two customlists with 3 items and 5 items in it, result list's 4th item should be the first lists's first index
        // Adding two customlists with 5 items and 3 items in it, result list's 6th item should be the second lists's first index
        [Test]
        public void PlusOperator_AddTwoCustomIntegerLists_FirstItemShouldBeTheFirstIndexOfFirstList()
        {
            // arrange
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            test1.Add(1);
            test1.Add(3);
            test1.Add(5);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            CustomClassList<int> result;
            int expected;
            int actual;

            // act
            result = new CustomClassList<int>();
            result = test1 + test2;
            actual = test1[0];
            expected = result[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlusOperator_AddTwoCustomIntegerListsTogether_LastItemShouldBeTheLastIndexOfSecondList()
        {
            // arrange
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            test1.Add(1);
            test1.Add(3);
            test1.Add(5);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            CustomClassList<int> result;
            int expected;
            int actual;

            // act
            result = new CustomClassList<int>();
            result = test1 + test2;
            actual = test2[2];
            expected = result[5];

            // assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void PlusOperator_AddTwoCustomIntegerListsWithTwoItems_ThirdItemShouldBeTheFirstIndexOfSecondList()
        {
            // arrange
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            test1.Add(1);
            test1.Add(3);
            test2.Add(2);
            test2.Add(4);
            CustomClassList<int> result;
            int expected;
            int actual;

            // act
            result = new CustomClassList<int>();
            result = test1 + test2;
            actual = test2[0];
            expected = result[2];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlusOperator_AddTwoCustomIntegerListsWithThreeAndFiveItems_FourthItemOfResultListShouldBeFirstIndexOfSecondList()
        {
            // arrange
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test2.Add(4);
            test2.Add(5);
            test2.Add(6);
            test2.Add(7);
            test2.Add(8);
            CustomClassList<int> result;
            int expected;
            int actual;

            // act
            result = new CustomClassList<int>();
            result = test1 + test2;
            actual = test2[0];
            expected = result[3];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlusOperator_AddTwoCustomIntegerListsWithFiveAndThreeItems_SixthItemOfResultListShouldBeFirstIndexOfSecondList()
        {
            // arrange
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            test2.Add(1);
            test2.Add(2);
            test2.Add(3);
            test1.Add(4);
            test1.Add(5);
            test1.Add(6);
            test1.Add(7);
            test1.Add(8);
            CustomClassList<int> result;
            int expected;
            int actual;

            // act
            result = new CustomClassList<int>();
            result = test1 + test2;
            actual = test2[0];
            expected = result[5];

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}