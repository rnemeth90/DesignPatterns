using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class SingletonClass
    {
        private static SingletonClass _instance;
        private static readonly object _instanceLock = new object();

        public string Value { get; set; }

        private SingletonClass()
        {

        }

        public static SingletonClass GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_instanceLock)
                { 
                    if(_instance == null)
                    {
                        _instance = new SingletonClass();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }
    }
}
