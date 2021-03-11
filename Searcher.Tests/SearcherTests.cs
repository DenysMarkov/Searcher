using NUnit.Framework;
using System;

namespace Searcher.Tests
{
    public class Tests
    {
        Searcher searcher;

        [SetUp]
        public void Setup()
        {
            searcher = new Searcher();
        }

        [Test]
        public void FoundMax2nd_EmptyArray_ArgumentException()
        {
            //arrange
            int[] array = new int[] { };

            //act & assert
            Assert.Throws<ArgumentException>(() => searcher.FoundMax2nd(array));
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void FoundMax2nd_1elementArray_ArgumentException(int value)
        {
            //arrange
            int[] arrayInt = { value };

            // act & assert
            Assert.Throws<ArgumentException>(() => searcher.FoundMax2nd(arrayInt));
        }

        [TestCase(new int[] {-2, -2})]
        [TestCase(new int[] { 7, 7, 7, 7, 7 })]
        public void FoundMax2nd_EqualsElementsArray_ArgumentException(int[] arrayInt)
        {
            // arrange, act & assert
            Assert.Throws<ArgumentException>(() => searcher.FoundMax2nd(arrayInt));;
        }

        [Test]
        public void FoundMax2nd_2elementsArray_negat5returned()
        {
            //arrange
            int[] arrayInt = { -5, 2 };
            int except = -5;

            // act
            int actual = searcher.FoundMax2nd(arrayInt);

            //assert
            Assert.AreEqual(except, actual);
        }

        [Test]
        public void FoundMax2nd_2elementsArray_intMinValueReturned()
        {
            //arrange
            int[] arrayInt = { int.MinValue, 2 };
            int except = int.MinValue;

            // act
            int actual = searcher.FoundMax2nd(arrayInt);

            //assert
            Assert.AreEqual(except, actual);
        }

        [Test]
        public void FoundMax2nd_3ElementsArrayInWhich2Equals_0returned()
        {
            //arrange
            int[] arrayInt = { 2, 2, 0 };
            int except = 0;

            // act
            int actual = searcher.FoundMax2nd(arrayInt);

            //assert
            Assert.AreEqual(except, actual);
        }

        [Test]
        public void FoundMax2nd_5ElementsArrayInWhich2GroupWithEqualsElements_1returned()
        {
            //arrange
            int[] arrayInt = { 2, 2, 1, 1, 1 };
            int except = 1;

            // act
            int actual = searcher.FoundMax2nd(arrayInt);

            //assert
            Assert.AreEqual(except, actual);
        }

        [Test]
        public void FoundMax2nd_NegativeAndPositiveValuesAnd2ndMaxElementIs9_9returned()
        {
            //arrange
            int[] arrayInt = { -1, 2, 4, -5, 7, 8, 9, 10 };
            int except = 9;

            // act
            int actual = searcher.FoundMax2nd(arrayInt);

            //assert
            Assert.AreEqual(except, actual);
        }
    }
}
