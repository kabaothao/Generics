using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }


        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }



        public class GenericDictionary<Tkey, TValue>
        {
            public void Add(Tkey key, TValue value)
            {

            }
        }

        public class GenericList<T> //T short for type or template
        {
            public void Add(T value)
            {

            }

            public T this[int index]
            {
                get { throw new NotImplementedException(); }
            }

        }
    }
}
