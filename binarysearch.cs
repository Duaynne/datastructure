using System;

namespace binarysearch
{
    class BS
    {
        static int binarySearch (int [] array, int x, int low, int high)
        {
            // Repeat until the pointers low and high meet each other
            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (array[mid] == x)
                    return mid;

                if (array[mid] < x)
                    low = mid + 1;

                else
                    high = mid - 1;
            }
            return -1;
        }

        public static void Mainbinary()
        {
            int[] array = {45,87,30,20,97,63};
            int searchitem = 40;
            int n = array.Length;

            int result = binarySearch(array, searchitem, 0, n - 1);
            if (result == -1)
                Console.WriteLine("Not found");
            else
                Console.WriteLine("Element is found at index: " + result);
        }
    }
}
