using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ps = new Person("Marry", 40);
            ps.Output();
            ps.Age += 1;
            ps.Output();
        }
    }
}
