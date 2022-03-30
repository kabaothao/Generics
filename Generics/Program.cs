﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Generics // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = '1111', Title = "C# Advanced" };

            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new BookList());
        }


        //System.Collections.Generic.

        var dictionary = new GenericDictionary<string, Book>();
        dictionary.Add("123", new Book());


    }
}

/*
 
Generics introduces the concept of type parameters to .NET, which make it possible to design classes and methods that defer the specification of 
one or more types until the class or method is declared and instantiated by client code. For example, by using a generic type parameter T, 
you can write a single class that other client code can use without incurring the cost or risk of runtime casts or boxing operations, as shown here:



 */