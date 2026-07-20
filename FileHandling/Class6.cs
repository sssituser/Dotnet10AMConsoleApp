using System;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace FileHandling
{
    internal class Class6
    {
        // 1 bytes - 8bits
        // 1024bytes - 1KB
        ///1024KB - 1MB
        ///1024MBS-1GB
        static void Main(string[] args)
        {

           DriveInfo[] drives = DriveInfo.GetDrives();
            
            foreach (DriveInfo drive in drives)
            {
                long drivesize = (drive.TotalSize) / (1024 * 1024 * 1024);
                long freespace = drive.TotalFreeSpace/ (1024 * 1024*1024);
                long usedspace = drivesize - freespace;
                Console.WriteLine($"Driver Name : {drive.Name.Substring(0,drive.Name.Length-2)} Drive,Driver Size : {drivesize} GB,Used Space : {usedspace} GB,Free Space : {freespace} GB");
               
            }
        }
    }
}
