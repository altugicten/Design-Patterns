using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonAsync
    {
        private SingletonAsync()
        {
            Console.WriteLine("Singleton oluşturuldu!");
        }

        static SingletonAsync _instance;
        static object _obj = new object();

        public static SingletonAsync GetInstanceAsyncExample()
        {
            lock (_obj)
            {
                if (_instance == null)
                    _instance = new SingletonAsync();
            }

            return _instance;
        }
    }
}
