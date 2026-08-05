using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class QueueExample
    {
        static void Main(string[] args)
        {
            Queue<int> st = new Queue<int>();
            while (true)
            {
            Menu:
                Console.Write("1.Insert\n2.Delete\n3.Show\n4.Top Element\nEnter Your choice : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter an Integer : ");
                        int num = int.Parse(Console.ReadLine());
                        st.Enqueue(num);
                        goto Menu;
                    case 2:
                        if (st.Count == 0)
                        {
                            Console.WriteLine("Queue is Empty");
                        }
                        else
                        {
                            Console.WriteLine($"Deleted Element is : {st.Dequeue()}");
                        }
                        goto Menu;
                    case 3:
                        if (st.Count == 0)
                        {
                            Console.WriteLine("Queue is Empty");
                        }
                        else
                        {
                            Console.WriteLine("===========Queue Elements are===========");
                            foreach (var item in st)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        goto Menu;
                    case 4:
                        if (st.Count == 0)
                        {
                            Console.WriteLine("Queue is Empty");
                        }
                        else
                        {
                            Console.WriteLine($"Top Element in the Queue is : {st.Peek()}");
                        }
                        goto Menu;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
