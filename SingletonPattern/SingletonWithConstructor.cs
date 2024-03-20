using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonWithConstructor
    {
        static SingletonWithConstructor _example;

        private SingletonWithConstructor()
        {
            Console.WriteLine("Singletion static contstructor methodu ile oluşturuldu!");
        }

        static SingletonWithConstructor()
        {
            _example = new SingletonWithConstructor();
        }

        public static SingletonWithConstructor GetInstance
        {
            get { return _example; }
        }

    }
}
