// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Generics // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            //you can find in system.null

            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value ? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());


        }
           


    }
}

/*
 
Generics introduces the concept of type parameters to .NET, which make it possible to design classes and methods that defer the specification of 
one or more types until the class or method is declared and instantiated by client code. For example, by using a generic type parameter T, 
you can write a single class that other client code can use without incurring the cost or risk of runtime casts or boxing operations, as shown here:



 */