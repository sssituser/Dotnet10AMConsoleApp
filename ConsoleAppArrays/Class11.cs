using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            int[][] jarray = new int[3][];
            jarray[0] = new int[3] {10,40,50};
            jarray[1] = new int[2] {80,70};
            jarray[2] = new int[4] {55,45,75,35};
            Console.WriteLine("==========Jagged Array Elements=======");
            for (int i = 0; i < jarray.Length; i++)
            {
                for(int j = 0; j < jarray[i].Length; j++)
                {
                    Console.Write($"{jarray[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
