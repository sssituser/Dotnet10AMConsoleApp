using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Class12
    {
        static void Main(string[] args)
        {
           bool bl = true;
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
            while (bl)
            {
            Options:
                Console.Write("1.Add\n2.Delete\n3.Find\n4.Keys\n5.Values\nEnter Your choice :");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Key : ");
                        int k = int.Parse(Console.ReadLine());
                        Console.Write("Enter value : ");
                        string v = Console.ReadLine();
                        if (sd.ContainsKey(k))
                        {
                            Console.WriteLine("Key already exists");
                        }
                        else
                        {

                            sd.Add(k, v);
                            Console.WriteLine("Key valules added succesfully");
                        }
                        break;
                    case 2:
                        if (sd.Count == 0)
                        {
                            Console.WriteLine("Dictionary is Empty");
                        }
                        else
                        {
                            Console.Write("Enter key : ");
                            k = int.Parse(Console.ReadLine());
                            if (sd.Remove(k))
                            {
                                Console.WriteLine("Removed Successfully...");
                            }
                            else
                            {
                                Console.WriteLine("Not Removed");
                            }

                        }
                        break;
                    case 3:
                        if (sd.Count == 0)
                        {
                            Console.WriteLine("Dicitonary is Empty");
                        }
                        else
                        {
                            foreach (KeyValuePair<int, string> kvp in sd)
                            {
                                Console.WriteLine(kvp);
                            }
                        }
                        break;
                    case 4:
                        if (sd.Count == 0)
                        {
                            Console.WriteLine("Dicitonary is Empty");
                        }
                        else
                        {
                            foreach(int key in sd.Keys)
                            {
                                Console.WriteLine(key);
                            }
                        }
                        break;
                    case 5:
                        if (sd.Count == 0)
                        {
                            Console.WriteLine("Dicitonary is Empty");
                        }
                        else
                        {
                            foreach (string vals in sd.Values)
                            {
                                Console.WriteLine(vals);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice : ");
                        break;

                }
            Back:
                Console.Write("Do You Want To Continue (Y/N) : ");
                string con = Console.ReadLine();
                Console.Clear();
                if(con.Equals("y")||con.Equals("Y"))
                {
                    bl = true;
                    goto Options;
                }
                else if(con.Equals("n")||con.Equals("N"))
                {
                    bl = false;
                    break;
                }
                goto Back;

            }
        }
    }
}
