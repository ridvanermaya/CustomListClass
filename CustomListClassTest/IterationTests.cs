using System;
using NUnit.Framework;
using CustomClassListProject;
using FluentAssertions;

namespace Tests
{
    public class IterationTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        // Iterating the list, adding the numbers in the list, sumg of all the numbers
        [Test]
        public void Iteration_AddNumbersInTheList_SumOfTheNumbers()
        {
            // arrange
            CustomClassList<int> test = new CustomClassList<int>();
            test.Add(0);
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);
            int expected = 15;
            int actual = 0;

            // act
            foreach(int item in test) {
                actual += item;
            }

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}