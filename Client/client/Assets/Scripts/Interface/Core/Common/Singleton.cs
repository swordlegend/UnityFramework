using System;
using System.Collections;
using System.Diagnostics;

namespace gtmInterface
{
    public class Singleton<T> where T : new()
    {
        protected static T _instance = default(T);

        protected Singleton()
        {
            
        }

        public static T instance
        {
            get
            {
                if (_instance == null)
                {
                    if (_instance == null)
                    {
                        _instance = new T();
                    }
                }

                return _instance;
            }
        }
    }
}