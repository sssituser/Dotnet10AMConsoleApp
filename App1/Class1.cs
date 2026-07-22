using NewSystem;

namespace App1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to SSSIT");
            int num = 10;
            MyConsole.PrintLine($"num = {num}");
            MyConsole.Print("Enter An Integer : ");
            int num2 = MyConsole.ReadInt();
            MyConsole.Print("Enter a Double value : ");
            double d = MyConsole.ReadDouble();
            MyConsole.PrintLine($"Entered values are num2 = {num2}  d = {d}");

            MyConsole.PrintLine(CheckNums.IsPalindrome(121)+"");
            MyConsole.PrintLine($"{CheckNums.IsAdam(12)}");

        }
    }
}
