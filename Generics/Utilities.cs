// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Generics // Note: actual namespace depends on the project name.
{
    public class Utilities<T> where T : IComparable, new() //So what you can do is to apply a second constraint here. You can separate constraints with the comma.
    {



        //where T : IComparable
        //where T : Product
        //where T : struct
        //where T : class
        //where T : new()

        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }


        public void DoSomething(T value)
        {
            //ow let's say in some specific scenarios we want to instantiate an instance of T.So if you want to create an object you want to do something like that.

            var obj = new T();
        }


        public T Max(T a, T b)
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