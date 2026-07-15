using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            int[,] array1 = { { 1, 2 }, { 3, 4 } };
            int[,] array2 = { { 5, 6 }, { 7, 8 } };

            Console.WriteLine("==============Array-1 Elements========");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write($"{array1[row,col]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("==============Array-2 Elements========");
            for (int row = 0; row < 2; row++)
            {
                for(int col = 0; col < 2; col++)
                {
                    Console.Write($"{array2[row,col]}\t");
                }
                Console.WriteLine();
            }
            // logic for matrix multiplication
            int[,] res = new int[2, 2];
            for(int i = 0; i < 2; i++)   // i = 0  0<2  i = 1 1<2-T i = 2 2<2
            {
                for(int j = 0;j< 2; j++) // j = 0  0<2 j=1 1<2  j = 2 2<2-F
                {
                    for(int k = 0; k < 2; k++) // k = 0  k<2         k=1  1<2-T k=2 2<2-F
                    {
                        res[i, j] = array1[i, k] * array2[k, j] + res[i, j];
                        //res[0,0] = array1[0,0]*array2[0,0]+res[0,0]
                        // res[0,0] = 1*5+0 => res[0,0]=>5
                        //res[0,0] = arrray1[0,1]*array2[1,0]+res[0,0]
                        //res[0,0] =  2*7+5=>res[0,0]=>19

                        //res[0,1] = array1[0,0]*array2[0,1]+res[0,1]
                        //res[0,1] = 1*6+0 => res[0,1]=>6
                        //res[0,1]=array1[0,1]*array2[1,1]+res[0,1]
                        //res[0,1] = 2*8+6=> res[0,1] = 22

                        //res[1,0] = array1[1,0]*array2[0,0]+res[1,0]
                        //res[1,0] = 3*5+0=> res[1,0] = 15
                        //res[1,0] = array1[1,1]*array2[1,0]+res[1,0]
                        //res[1,0] = 4*7+15=>43

                        // res[1,1] = array1[1,0]*array2[0,1]+res[1,1]
                        //res[1,1] = 3*6+0=> res[1,1] = 18
                        //res[1,1] = array1[1,1]*array2[1,1]+res[1,1]
                        //res[1,1] = 4*8+18=> res[1,1]=>50


                    }
                }
            }

            Console.WriteLine("==============Multiplication of Array-1 and Array-2 Elements========");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write($"{res[row, col]}\t");
                }
                Console.WriteLine();
            }

        }
    }
}
