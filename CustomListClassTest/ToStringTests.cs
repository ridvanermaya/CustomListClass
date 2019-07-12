using System;
using NUnit.Framework;
using CustomClassListProject;
using FluentAssertions;

namespace Tests
{
    public class ToStringTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        // ToString a list of integers turns each number to one string
        // ToString a list of integers must not change the count
        // ToString a list should return string
        // Adding two booleans together and the result should be firstBool+secondBool
        [Test]
        public void ToString_ApplyToAListOfIntegers_TurnsEachNumberToString()
        {
            // arrange
            CustomClassList<int> test = new CustomClassList<int>();
            test.Add(0);
            test.Add(1);
            test.Add(2);
            test.Add(3);
            char expected = '1';
            string returnedString;
            char actual;

            // act
            returnedString = test.ToString();
            actual = returnedString[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToString_ApplyToAListOfIntegers_CountDontChange()
        {
            // arrange
            CustomClassList<int> test = new CustomClassList<int>();
            test.Add(0);
            test.Add(1);
            test.Add(2);
            test.Add(3);
            int expected = 4;
            int actual;

            // act
            test.ToString();
            actual = test.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToString_ApplyTOAListOfIntegers_ShouldReturnString()
        {
            // arrange
            CustomClassList<int> test = new CustomClassList<int>();
            test.Add(0);
            test.Add(1);
            test.Add(2);
            test.Add(3);
            string actual;

            // act
            actual = test.ToString();

            // assert
            actual.Should().Be("0123");
        }

        [Test]
        public void ToString_AListOfBooleans_ReturnFirstBoolPlusSecond()
        {
            // arrange
            CustomClassList<bool> test = new CustomClassList<bool>();
            test.Add(true);
            test.Add(false);
            test.Add(true);
            string actual;

            // act
            actual = test.ToString();

            // assert
            actual.Should().Be("truefalsetrue");
        }
    } 
}