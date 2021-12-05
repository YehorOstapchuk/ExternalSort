using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExternalSort
{
    public static class ShellSort
    {
        public static int Compare (string firstStr, string secondStr)
        {
            int first = int.Parse(firstStr);
            int second = int.Parse(secondStr);
            if (first == second) return 0;
            if (first < second) return -1;
            if (first > second) return 1;
            return 0;
        }
        public static string [] Sort(string [] arr)
        {
            int[] myInts = Array.ConvertAll(arr, s => int.Parse(s));
            Sort(myInts, myInts.Length);
            string [] ints = new string[arr.Length];
            int i = 0;
            foreach(var num in myInts)
            {
                ints[i] = num.ToString();
                i++;
            }
            return ints;
        }
        static void Sort(int[] arr, int array_size)
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }

    }
}
