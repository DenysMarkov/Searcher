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
            int[] testArrayInt = new int[] { };

            //act & assert
            Assert.Throws<ArgumentException>(() => searcher.FoundMax2nd(testArrayInt));
        }

        #region Test Cases
        [TestCase(int.MinValue)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(int.MaxValue)]
        #endregion
        public void FoundMax2nd_1elementArray_ArgumentException(int valueFromTestCase)
        {
            //arrange
            int[] testArrayInt = { valueFromTestCase };

            // act & assert
            Assert.Throws<ArgumentException>(() => searcher.FoundMax2nd(testArrayInt));
        }

        #region Test Cases
        [TestCase(new int[] { int.MinValue, int.MinValue })]
        [TestCase(new int[] { int.MinValue, int.MinValue, int.MinValue, int.MinValue })]
        [TestCase(new int[] { -2, -2})]
        [TestCase(new int[] { 0, 0})]
        [TestCase(new int[] { 7, 7, 7, 7, 7 })]
        [TestCase(new int[] { int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue })]
        [TestCase(new int[] { int.MaxValue, int.MaxValue })]
        #endregion
        public void FoundMax2nd_EqualsElementsArray_ArgumentException(int[] arrayFromTestCase)
        {
            // arrange, act & assert
            Assert.Throws<ArgumentException>(() => searcher.FoundMax2nd(arrayFromTestCase));;
        }

        #region Test Cases
        [TestCase(new int[] { int.MinValue, 2 })]
        [TestCase(new int[] { int.MinValue, 0 })]
        [TestCase(new int[] { int.MinValue, -1 })]
        [TestCase(new int[] { -1, int.MinValue })]
        [TestCase(new int[] { 0, int.MinValue })]
        [TestCase(new int[] { 2, int.MinValue })]
        #endregion
        public void FoundMax2nd_2elementsArrayWithIntMinValue_intMinValueReturned(int[] arrayFromTestCase)
        {
            //arrange
            int[] testArrayInt = arrayFromTestCase;
            int except = int.MinValue;

            // act
            int actual = searcher.FoundMax2nd(testArrayInt);

            //assert
            Assert.AreEqual(except, actual);
        }

        #region Test Cases
        [TestCase(  0 , new int[] { 0, 2 })]
        [TestCase(  0 , new int[] { 2, 0 })]
        [TestCase( -2 , new int[] { -2, 0 })]
        [TestCase( -2 , new int[] { 0, -2 })]
        [TestCase( -5 , new int[] {-5, 2 })]
        #endregion
        public void FoundMax2nd_2elementsArray_exceptedValueFromTestCaseReturned(int exceptedValueFromTestCase,
            int [] arrayFromTestCase)
        {
            //arrange
            int[] testArrayInt = arrayFromTestCase;
            int except = exceptedValueFromTestCase;

            // act
            int actual = searcher.FoundMax2nd(testArrayInt);

            //assert
            Assert.AreEqual(except, actual);
        }

        #region Test Cases
        [TestCase(  0 , new int[] { 2, 2, 0 })]
        [TestCase(  0 , new int[] { 2, 0, 2 })]
        [TestCase( -2 , new int[] { -2, 0, 0 })]
        [TestCase( 1 , new int[] { 2, 2, 1, 1, 1 })]
        [TestCase( -5 , new int[] { -5, -5, -5, 2, 2 })]
        #endregion
        public void FoundMax2nd_ArrayInWhich2GroupsWithEqualsElements_exceptedValueFromTestCaseReturned
            (int exceptedValueFromTestCase, int [] arrayFromTestCase)
        {
            //arrange
            int[] testArrayInt = arrayFromTestCase;
            int except = exceptedValueFromTestCase;

            // act
            int actual = searcher.FoundMax2nd(testArrayInt);

            //assert
            Assert.AreEqual(except, actual);
        }

        #region Test Cases
        [TestCase(  9 , new int[] { -1, 2, 4, -5, 7, 8, 10, 9 })]
        [TestCase(  8 , new int[] { -1, 2, -4, -5, 7, 8, 1, 10 })]
        [TestCase(  7 , new int[] { 7, int.MinValue, 2, -5, 4, 8, -2 })]
        #endregion
        public void FoundMax2nd_IntArrayWithDifferentValues_exceptedValueFromTestCaseReturned
            (int exceptedValueFromTestCase, int [] arrayFromTestCase)
        {
            //arrange
            int[] testArrayInt = arrayFromTestCase;
            int except = exceptedValueFromTestCase;

            // act
            int actual = searcher.FoundMax2nd(testArrayInt);

            //assert
            Assert.AreEqual(except, actual);
        }
    }
}