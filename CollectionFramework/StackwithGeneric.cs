using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class StackwithGeneric
    {
        static void Main(string[] args)
        {
            Stack<int> st=new Stack<int>();
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
                        st.Push(num);
                        goto Menu;
                    case 2:
                        if (st.Count == 0)
                        {
                            Console.WriteLine("Stack is Empty");
                        }
                        else
                        {
                            Console.WriteLine($"Deleted Element is : {st.Pop()}");
                        }
                        goto Menu;
                    case 3:
                        if (st.Count == 0)
                        {
                            Console.WriteLine("Stack is Empty");
                        }
                        else
                        {
                            Console.WriteLine("===========StackElements are===========");
                            foreach (var item in st)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        goto Menu;
                    case 4:
                        if (st.Count == 0)
                        {
                            Console.WriteLine("Stack is Empty");
                        }
                        else
                        {
                            Console.WriteLine($"Top Element in the Stack is : {st.Peek()}");
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
