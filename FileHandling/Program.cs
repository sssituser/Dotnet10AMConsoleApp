using System;
using System.IO;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name With Location : ");
            string foname = Console.ReadLine();
            DirectoryInfo info = new DirectoryInfo(foname);

            if (info.Exists)
            {
                Console.WriteLine("Folder Exists");
            }
            else
            {
                Console.WriteLine("No Folder Exists with the name");
                Directory.CreateDirectory(foname);
                Console.WriteLine("Folder Created Successfully");
            }
           
        }
    }
}
