namespace GenericsApp
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            GenricEx2<int> obj1 = new GenricEx2<int>();
            obj1.Display(100,200);
            GenricEx2<double> obj2 = new GenricEx2<double>();
            obj2.Display(4.5,6.7);
            GenricEx2 <Employee> obj3 = new GenricEx2<Employee>();
            obj3.Display(new Employee(111,"kiran",6000),new Employee(555,"Raj",5000));
            GenricEx2<Student> obj4 = new GenricEx2<Student>();
            obj4.Display(new Student(111,"Arun","B.Tech CSE"),new Student(112,"Ravi","MCA"));
        }
    }
}
