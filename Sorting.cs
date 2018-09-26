namespace Algorithms
{
    class Sorting
    {
        public static void QuickSort(int[] arr, int startIndex, int lastIndex)
        {
            if (arr.Length == 0) return;
            int pointer = arr[lastIndex];
            int i = startIndex, y = lastIndex;
            while (i <= y)
            {
                while (arr[i] < pointer && i <= lastIndex) ++i;
                while (arr[y] > pointer && y >= startIndex) --y;
                if (i <= y)
                {
                    int temp = arr[i];
                    arr[i] = arr[y];
                    arr[y] = temp;
                    ++i; --y;
                }
            }
            if (y > startIndex) QuickSort(arr, startIndex, y);
            if (i < lastIndex) QuickSort(arr, i, lastIndex);
        }
        public static void MergeSort(int[] arr)
        {
            int[] b;
            int[] c;

            if (arr.Length == 1)
                return;
            else if (arr.Length == 2)
            {
                b = new int[arr.Length / 2];
                c = new int[arr.Length / 2];
                b[0] = arr[0];
                c[0] = arr[1];
                int tmp = b[0];
                int tmp1 = c[0];

                if (tmp > tmp1)
                {
                    arr[0] = tmp1;
                    arr[1] = tmp;
                }
                else
                {
                    arr[1] = tmp1;
                    arr[0] = tmp;
                }
                return;
            }
            else if (arr.Length > 2)
            {
                if ((arr.Length % 2) == 1)
                    b = new int[(arr.Length / 2) + 1];
                else if (arr.Length % 2 == 0)
                    b = new int[arr.Length / 2];
                else
                    b = new int[arr.Length];

                for (int i = 0; i < b.Length; i++)
                    b[i] = arr[i];

                c = new int[arr.Length - b.Length];
                int counter;
                if (arr.Length % 2 == 0)
                    counter = c.Length;
                else
                    counter = c.Length + 1;

                for (int i = 0; i < arr.Length / 2; i++)
                {
                    c[i] = arr[counter];
                    counter++;
                }

                MergeSort(b);
                MergeSort(c);

                int x = 0;
                int y = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (x >= b.Length)
                    {
                        arr[i] = c[y];
                        y++;
                    }
                    else if (y >= c.Length)
                    {
                        arr[i] = b[x];
                        x++;
                    }
                    else
                    {
                        if (b[x] < c[y])
                        {
                            arr[i] = b[x];
                            x++;
                        }
                        else if (c[y] < b[x])
                        {
                            arr[i] = c[y];
                            y++;
                        }
                        else if (c[y] == b[x])
                        {
                            arr[i] = b[x];
                            i++;
                            arr[i] = c[y];
                            x++;
                            y++;
                        }
                    }
                }
                return;
            }
            else
                return;
        }
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int y = 0; y < arr.Length; y++)
                {
                    if (arr[i] < arr[y])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[y];
                        arr[y] = tmp;
                    }
                }
            }
        }
        public static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int sortItem = arr[i];
                int y = i;
                while (y > 0 && arr[y - 1] > sortItem)
                {
                    arr[y] = arr[y - 1];
                    y--;
                }
                arr[y] = sortItem;
            }
        }
        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int MinValue = arr[i];
                int index = i;
                for (int y = i + 1; y < arr.Length; y++)
                {
                    if (MinValue > arr[y])
                    {
                        MinValue = arr[y];
                        index = y;
                    }
                }
                int temp = arr[i];
                arr[i] = MinValue;
                arr[index] = temp;
            }
        }
    }
}
