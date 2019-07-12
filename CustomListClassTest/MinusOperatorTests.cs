using System;
using NUnit.Framework;
using CustomClassListProject;
using FluentAssertions;

namespace Tests
{
    public class MinusOperatorTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        // Substracting a list from another, if no items match then return should be the first list
        // Substracting uneven lists first list has more items, should remove all matched items from the first list
        // Substracting uneven lists second list has more items. should remove all the matched items from the first list
        // Substracting a list from another, there shouldn't be any items that matche with the items in second list
        [Test]
        public void MinusOperator_SubstractingWithNoMatchingItems_ShouldReturnFirstList()
        {
            // arrange
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            CustomClassList<int> expected = new CustomClassList<int>();
            CustomClassList<int> actual = new CustomClassList<int>();
            test1.Add(0);
            test1.Add(1);
            test1.Add(2);
            test2.Add(3);
            test2.Add(4);
            test2.Add(5);
            expected.Add(0);
            expected.Add(1);
            expected.Add(2);
            expected[0] = 0;
            expected[1] = 1;
            expected[2] = 2;

            // act
            actual = test1 - test2;

            // assert
            expected.Should().BeSameAs(actual);
        }

        [Test]
        public void MinusOperator_SubstractingFirstListHasMoreItems_ShouldReturnSubstractedList()
        {
            // arrange
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            CustomClassList<int> expected = new CustomClassList<int>();
            CustomClassList<int> actual = new CustomClassList<int>();
            test1.Add(0);
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test1.Add(4);
            test1.Add(5);
            test2.Add(1);
            test2.Add(3);
            test2.Add(5);
            expected.Add(0);
            expected.Add(2);
            expected.Add(4);
            
            // act
            actual = test1 - test2;
            
            // assert
            expected.Should().BeSameAs(actual);
        }

        [Test]
        public void MinusOperator_SubstractingSecondListHasMoreItems_ShouldReturnSubstractedList()
        {
            // arrange
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            CustomClassList<int> expected = new CustomClassList<int>();
            CustomClassList<int> actual = new CustomClassList<int>();
            test1.Add(0);
            test1.Add(1);
            test1.Add(2);
            test2.Add(1);
            test2.Add(3);
            test2.Add(4);
            test2.Add(5);
            expected.Add(0);
            expected.Add(2);

            // act
            actual = test1 - test2;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MinusOperator_SubstractingTwoLists_ResultListShouldNotIncludeAnyItemsFromSecondList()
        {
            // arrange
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            CustomClassList<int> expected = new CustomClassList<int>();
            CustomClassList<int> actual = new CustomClassList<int>();
            test1.Add(0);
            test1.Add(1);
            test1.Add(2);
            test2.Add(1);
            test2.Add(2);
            test2.Add(5);
            expected.Add(0);

            // act
            actual = test1 - test2;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}