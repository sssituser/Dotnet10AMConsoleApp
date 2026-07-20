using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Menu:
                Console.Write("Enter File Name With Location : ");
                string fname = Console.ReadLine();
                FileInfo finfo = new FileInfo(fname);
            
                Console.Write("1.Create File \n2.Delete File \n3.Check File\n4.Write\n5.Read\n6.Drives Info\nEnter Your Choice : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (finfo.Exists)
                        {
                            Console.WriteLine("File Can't be create with Name");
                        }
                        else
                        {
                            File.Create(fname);
                            Console.WriteLine("File Created Successfully....");
                        }
                        goto Menu;
                    case 2:
                        if (finfo.Exists)
                        {
                            File.Delete(fname);
                            Console.WriteLine("File Deleted");
                        }
                        else
                        {

                            Console.WriteLine("File Does't Exists....");
                        }

                        goto Menu;
                    case 3:

                        if (finfo.Exists)
                        {
                            Console.WriteLine("File Exists With The Given Name ");
                        }
                        else
                        {
                            Console.WriteLine("File Doen't Exists With The Given Name");

                        }
                        goto Menu;
                    case 4:
                        StreamWriter sw = new StreamWriter(fname,true);
                        Console.WriteLine("------------------Enter Your Inforation--------------");
                        string info = string.Empty;
                        while(!string.IsNullOrEmpty((info = Console.ReadLine())))
                        {
                            sw.WriteLine(info);
                        }
                        sw.Close();
                        goto Menu;
                    case 5:
                        StreamReader sr = new StreamReader(fname);
                        Console.WriteLine("==================Your Infomation is=============");
                        Console.WriteLine(sr.ReadToEnd());
                        sr.Close();
                        goto Menu;
                    case 6:
                        DriveInfo[] drives = DriveInfo.GetDrives();

                        foreach (DriveInfo drive in drives)
                        {
                            long drivesize = (drive.TotalSize) / (1024 * 1024 * 1024);
                            long freespace = drive.TotalFreeSpace / (1024 * 1024 * 1024);
                            long usedspace = drivesize - freespace;
                            Console.WriteLine($"Driver Name : {drive.Name.Substring(0, drive.Name.Length - 2)} Drive,Driver Size : {drivesize} GB,Used Space : {usedspace} GB,Free Space : {freespace} GB");

                        }
                        goto Menu;
                    default:
                        Console.WriteLine("Invalid choice....Enter Proper Choice..");
                        goto Menu;
                }

            }
        }
    }
}