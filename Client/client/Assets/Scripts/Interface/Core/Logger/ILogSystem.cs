using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmInterface
{
    public interface ILogTag
    {
        string LOG_TAG { get; }
    }

    public interface ILogSystem : IManager
    {      
        void Log(object obj);

        void Log(string message);

        void Log(string format, params object[] args);

        void LogWarning(object obj);
        
        void LogWarning(string message);
             
        void LogWarning(string format, params object[] args);

        void LogError(object obj);

        void LogError(string message);

        void LogError(string format, params object[] args);
    }
}
