using System;
using CustomClassListProject;
using NUnit.Framework;
using FluentAssertions;

namespace Tests
{
    public class IndexerTests
    {
        [SetUp]
        public void SetUp()
        {

        }
        
        // Trying to get an index the list doesn't contain throws an error
        [Test]
        public void Indexer_GettingValueOfIndexNotExists_ThrowsError()
        {
            // Arrange
            CustomClassList<int> test = new CustomClassList<int>();
            test.Add(0);
            test.Add(1);
            test.Add(2);
            test.Add(3);
            int value;

            // Act
            Action act = () => value = test[4];

            // Assert
            act.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}