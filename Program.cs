using System;

namespace ArrayManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayClass<int> a = new ArrayClass<int>(3);
            /*
                Your code...
            */
            a.arr[15] = 23;
            Console.WriteLine(a.arr[15]);
        }
    }
}
