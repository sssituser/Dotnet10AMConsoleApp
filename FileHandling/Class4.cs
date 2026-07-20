using System;
using System.IO;

namespace FileHandling
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name : ");
            string fname = Console.ReadLine();
            StreamWriter sw = new StreamWriter(fname,true);
            Console.Write("=======Enter Your Info=========================");
            string info = string.Empty;
            while (!string.IsNullOrEmpty((info = Console.ReadLine())))
            {
                sw.WriteLine(info);
            }
            sw.Close();
          
        }
    }
}
