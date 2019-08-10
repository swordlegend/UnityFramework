using System;
using System.Collections;
using System.Diagnostics;

namespace gtmEngine
{
    public class Singleton<T> where T : new()
    {
        protected static T _instance = default(T);
        private static Object _objLock = new System.Object();

        protected Singleton()
        {
            
        }

        public static void Depose()
        {
            _instance = default(T);
        }

        public static T instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_objLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new T();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}