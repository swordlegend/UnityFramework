using System;
using System.Collections;
using System.Diagnostics;

namespace gtmGame
{
    public class ClientSingleton<T> where T : new()
    {
        protected static T _instance = default(T);

        protected ClientSingleton()
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