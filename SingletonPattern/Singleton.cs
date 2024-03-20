﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private Singleton()
        {
            Console.WriteLine("Singleton oluşturuldu!");
        }

        static Singleton _instance;

        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();
                return _instance;
            }
        }

        public static Singleton GetInstanceAsyncExample()
        {
            if (_instance == null)
                _instance = new Singleton();
            return _instance;
        }
    }
}
