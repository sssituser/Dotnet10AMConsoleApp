using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Class8
    {
        static void Main(string[] args)
        {
          DriveInfo[] drivesinfo = DriveInfo.GetDrives(); // DriveInfo is class which gives info about a drive

            foreach (DriveInfo driveinfo in drivesinfo)
            {
                long totalsize = driveinfo.TotalSize / (1024*1024*1024);
                long freespace = driveinfo.TotalFreeSpace / (1024*1024*1024);
                long usedpace = totalsize - freespace;
                Console.WriteLine($"Drive Name : {driveinfo.Name} \tTotal size : {totalsize} GB\tUsed Space : {usedpace} GB\tFreeSpace : {freespace} GB");

                Console.WriteLine("Folders Present in the Driver Are");
                DirectoryInfo drive = driveinfo.RootDirectory;

                DirectoryInfo[] directories = drive.GetDirectories();
                foreach (DirectoryInfo dr in directories)
                {
                    Console.WriteLine(dr.Name);
                }
                Console.WriteLine("==============================");

            }
        }
    }
}
