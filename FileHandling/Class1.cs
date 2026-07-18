using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Folder Name : ");
            string foname = Console.ReadLine();
            DirectoryInfo Dinfo = new DirectoryInfo(foname);
            if (Dinfo.Exists)
            {
                Directory.Delete(foname, true);
                Console.WriteLine("Folder Deteted Successfully");
            }
            else
            {
                Console.WriteLine("Folder Doen't Exists With The Given Name");
            }
        }
    }
}
