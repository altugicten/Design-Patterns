using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonPublic
    {
        public SingletonPublic()
        {
            Console.WriteLine("Singleton public olarak oluşturuldu!");
        }

        public static SingletonPublic GetInstance { get ; set; }
    }
}
