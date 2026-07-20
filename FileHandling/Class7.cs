using System;
using System.IO;
namespace FileHandling
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Drive Name : ");
            string dname = Console.ReadLine();
            DriveInfo dr = new DriveInfo(dname);
            DirectoryInfo directoryInfo = dr.RootDirectory;
            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
            foreach (DirectoryInfo dirInfo in directoryInfos)
            {
                Console.WriteLine(dirInfo);
            }


        }
    }
}
