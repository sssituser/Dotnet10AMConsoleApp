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
                FileInfo info = new FileInfo(fname);
            
                Console.Write("1.Create File \n2.Delete File \n3.Check File\nEnter Your Choice : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (info.Exists)
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
                        if (info.Exists)
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

                        if (info.Exists)
                        {
                            Console.WriteLine("File Exists With The Given Name ");
                        }
                        else
                        {
                            Console.WriteLine("File Doen't Exists With The Given Name");

                        }
                        goto Menu;
                }

            }
        }
    }
}