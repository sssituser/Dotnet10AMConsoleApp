using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
namespace ConsoleAppMutltiThreading
{

    class ThreadExample
    {

        public string Name { get; set; }
        public void Player()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Player {Name} is Playing {i} time");
                Thread.Sleep(5000);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadExample p1 = new ThreadExample();
            p1.Name = "Maruti";
            ThreadExample p2 = new ThreadExample();
            p2.Name = "Fayaz";

            Thread t1 = new Thread(p1.Player); // Unstarted state thread
            Thread t2 = new Thread(p2.Player); // unstarted state
           
            t1.Priority = ThreadPriority.Lowest; // Highest  AboveNoraml  Normal BelowNormal lowest
            t2.Priority = ThreadPriority.Highest;
            t1.Name = p1.Name;
            t2.Name = p2.Name;
            t1.Start(); // Ready state
            t2.Start();  //Ready state
            t1.Join(50000);
   








        }
    }
}
