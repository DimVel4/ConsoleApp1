using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo<int,string> foo = new Foo<int,string>(3);
            foo.SampleMethod("fffff");

            Console.ReadKey();
        }

        interface ISample<T,T1>
        {
            T Val { get; }
            T1 Val1 { get; }
        }

        class Foo<T,T1> : ISample<T,T1>
        {
            private T _val;
            T1 _val1;
            public T Val => _val;
            public T1 Val1 => _val1;
            public Foo(T val)
            {
                this._val = val;
            }

            public void SampleMethod(T1 _val1)
            {
                this._val1 = _val1;
                Console.WriteLine($"{Val}, {Val1}");
            }


        }

    }
}
