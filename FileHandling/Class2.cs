using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Menu:
                Console.Write("1.Create Folder\n2.Delete Folder\n3.CheckFolder\nEnter Your choice : ");
                int choice = int.Parse(Console.ReadLine());
                Console.Write("Enter Folder Name : ");
                string foname = Console.ReadLine();
                DirectoryInfo directoryInfo = new DirectoryInfo(foname);
                switch (choice)
                {
                    case 1:
                        if (directoryInfo.Exists)
                        {
                            Console.WriteLine($"Folder Exists With {foname},Try with a new name");
                        }
                        else
                        {
                            Directory.CreateDirectory(foname);
                            Console.WriteLine("Folder Created Successfully");
                        }
                        goto Menu;
                    case 2:
                        if (directoryInfo.Exists)
                        {
                            Directory.Delete(foname);
                            Console.WriteLine("Folder Deleted Successfully");
                        }
                        else
                        {
                                 Console.WriteLine($"Folder Does't Exists With {foname},Try with a new name");
                        }
                        goto Menu;
                    case 3:
                        if (directoryInfo.Exists)
                        {
                            Console.WriteLine("Folder Exists with Same Name");
                        }
                        else
                        {
                            Console.WriteLine($"Folder Does't Exists With the Name {foname}");
                        }
                        goto Menu;
                    default:
                        Console.WriteLine("Invalid Choice....");
                        goto Menu;

                }

               

            }
        }
    }
}
