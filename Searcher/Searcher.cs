using System;

namespace Searcher
{
    public class Searcher
    {
        /// <summary>
        /// Searching and return second max number in array.
        /// </summary>
        /// <param name="inputArray">An array in which to search for a number.</param>
        /// <returns></returns>
        public int FoundMax2nd(int[] inputArray)
        {
            if (inputArray.Length < 2)
            {
                throw new ArgumentException("The array is too small to contain" +
                    " the second max element.", "inputArray");
            }

            bool isContainDifferentElem = default;
            int result = int.MinValue;

            for (int i = 1, maxnumber = inputArray[0]; i < inputArray.Length; i++)
            {
                if (inputArray[i].CompareTo(maxnumber) != 0)
                {
                    isContainDifferentElem = true;

                    if (inputArray[i] > maxnumber)
                    {
                        result = maxnumber;
                        maxnumber = inputArray[i];
                    }
                    else if (inputArray[i] > result)
                    {
                        result = inputArray[i];
                    }
                }
            }

            if (!isContainDifferentElem)
            {
                throw new ArgumentException("The array cannot contain the second max element" +
                    " due to hasn't different elements.", "inputArray");
            }
            else
            {
                return result;
            }
        }
    }
}