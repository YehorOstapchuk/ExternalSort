using System;
using System.IO;

namespace ExternalSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            using (var sw = new StreamWriter(@"C:\Users\yostap\source\repos\ExternalSort\ExternalSort\File.txt"))
            {
                for (int line = 0; line < 5000; line++)
                {
                    sw.WriteLine(rand.Next(0, 10000000).ToString());
                }
            }
            ExternalSort.Split(@"C:\Users\yostap\source\repos\ExternalSort\ExternalSort\File.txt", 200);
            ExternalSort.SortTheChunks();
            ExternalSort.MergeTheChunks(20, 250000);
        }
    }
}
