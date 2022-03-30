// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Generics // Note: actual namespace depends on the project name.
{
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }


    }



}

/*
 
Generics introduces the concept of type parameters to .NET, which make it possible to design classes and methods that defer the specification of 
one or more types until the class or method is declared and instantiated by client code. For example, by using a generic type parameter T, 
you can write a single class that other client code can use without incurring the cost or risk of runtime casts or boxing operations, as shown here:



 */