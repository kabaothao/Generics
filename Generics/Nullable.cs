// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Generics // Note: actual namespace depends on the project name.
{
    public class Nullable<T> where T : struct //So this nullable is using a constraint to specify that T has to be a value type.
    {
        
         //what is this use for? value types cannot be null. we wil use this class to give values to be nullable

        private object _value;

        public Nullable()
        {

        }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }

        }
        

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }


    }


}

/*
 
Generics introduces the concept of type parameters to .NET, which make it possible to design classes and methods that defer the specification of 
one or more types until the class or method is declared and instantiated by client code. For example, by using a generic type parameter T, 
you can write a single class that other client code can use without incurring the cost or risk of runtime casts or boxing operations, as shown here:



 */