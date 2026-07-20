using System;

using System.IO;

namespace FileHandling
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name To Rea The Info:");
            string fname = Console.ReadLine();
            StreamReader sr = new StreamReader(fname);
            Console.WriteLine("==================Your Infomation is=============");
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
