using NUnit.Framework;
using FluentAssertions;
using CustomClassListProject;

namespace Tests
{
    public class ZipTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        // Zipping two lists, first item in the result list should be the first item in the first list
        // Zipping two lists, last item in the result list should be the last item in the second list
        // Zipping two lists, second item in the result list should be the first item in second list
        // Zipping two lists, first list has 2 items, second list has 3 items, result list's 4th item should be second lists second item
        // Zipping two lists. first list has more items than the second list, extra items written at the end of the list
        // Zipping two lists, second list has more items than the first list, extra items written at the end of the list
        [Test]
        public void Zip_ZippingTwoListsWithTwoItems_FirstItemShouldBeFirstItemInTheFirstList()
        {
            // arrange
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            CustomClassList<int> result = new CustomClassList<int>();
            test1.Add(0);
            test1.Add(2);
            test2.Add(1);
            test2.Add(3);
            int expected = 0;
            int actual;
            
            // act
            result = test1.Zip(test2);
            actual = result[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Zip_TwoListsWithTwoItems_LastItemInTheResultListShouldBeTheLastItemInTheSecondList()
        {
            // arrange
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            CustomClassList<int> result = new CustomClassList<int>();
            test1.Add(0);
            test1.Add(2);
            test2.Add(1);
            test2.Add(3);
            int expected = 3;
            int actual;
            
            // act
            result = test1.Zip(test2);
            actual = result[3];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Zip_TwoListsWithTwoItems_SecondItemInTheResultListShouldBeTheFirstItemInTheSecondList()
        {
            // arrange
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            CustomClassList<int> result = new CustomClassList<int>();
            test1.Add(0);
            test1.Add(2);
            test2.Add(1);
            test2.Add(3);
            int expected = 1;
            int actual;
            
            // act
            result = test1.Zip(test2);
            actual = result[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Zip_FirstListHasTwoSecondListHasThreeItems_ResultListsFourthItemShouldBeSecondListsSecondItem()
        {
            // arrange
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            CustomClassList<int> result = new CustomClassList<int>();
            test1.Add(0);
            test1.Add(2);
            test2.Add(1);
            test2.Add(3);
            test2.Add(4);
            int expected = 3;
            int actual;
            
            // act
            result = test1.Zip(test2);
            actual = result[3];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Zip_FirstListHasMoreItems_ExtraItemsAddedAtTheEndOfTheResultList()
        {
            // arrange
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            CustomClassList<int> result = new CustomClassList<int>();
            test1.Add(0);
            test1.Add(2);
            test1.Add(4);
            test1.Add(6);
            test2.Add(1);
            test2.Add(3);
            int expected = 6;
            int actual;
            
            // act
            result = test1.Zip(test2);
            actual = result[5];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Zip_SecondListHasMoreItems_ExtraItemsShouldBeAddedAtTheEndOfTheResultList()
        {
            // arrange
            CustomClassList<int> test1 = new CustomClassList<int>();
            CustomClassList<int> test2 = new CustomClassList<int>();
            CustomClassList<int> result = new CustomClassList<int>();
            test1.Add(0);
            test1.Add(2);
            test2.Add(1);
            test2.Add(3);
            test2.Add(5);
            test2.Add(7);
            int expected = 7;
            int actual;
            
            // act
            result = test1.Zip(test2);
            actual = result[5];

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}