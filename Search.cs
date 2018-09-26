using System.Linq;


namespace Algorithms
{
    class Search
    {
        public static int BinarySearch(int[] array, int searchInt)
        {
            if (array.Length == 0 || array[0] > searchInt || array.Last() < searchInt)
                return -1;

            int rightSide = 0;
            int leftSide = array.Length;

            while (rightSide < leftSide)
            {
                int ptr = rightSide + (leftSide - rightSide) / 2;

                if (searchInt <= array[ptr])
                    leftSide = ptr;
                else
                    rightSide = ptr + 1;
            }

            if (array[leftSide] == searchInt)
                return leftSide;
            else
                return -1;
        }
        public static int LineSearch(int[] array, int searchObject)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchObject)
                    return i;
            }
            return -1;
        }
    }
}
