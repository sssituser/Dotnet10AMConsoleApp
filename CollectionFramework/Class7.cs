using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Class7
    {
        static void Main(string[] args)
        {
           Stack st=new Stack();
            st.Push(10);
            st.Push(56);
            st.Push(45);
            st.Push(90);
            st.Push(44);
            st.Push(55);
            Console.WriteLine("==================Stack Elements=========");
            foreach(int i in st)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"Total elements in the stack are : {st.Count}");
            Console.WriteLine($"Peek element or Top of the Stack : {st.Peek()}");
            Console.WriteLine($"Deleted Element is : {st.Pop()}");
            Console.WriteLine($"Deleted Element is : {st.Pop()}");

            Console.WriteLine("==================Stack Elements=========");
            foreach (int i in st)
            {
                Console.WriteLine(i);
            }

           
        }
    }
}
