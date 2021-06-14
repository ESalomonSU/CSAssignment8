using System;

namespace CSAssignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> myOwnClass = new MyClass<int>();
            myOwnClass.AnyNumber = 11;

            myOwnClass.PrintData(11);
        }
    }
}

public class MyClass<T>
{
    public T AnyNumber { get; set; }

    public void PrintData(T parameter)
    {
        Console.WriteLine("Value: " + parameter);
    }
}