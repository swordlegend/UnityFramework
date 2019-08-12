using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmInterface
{
    public interface ILogTag
    {
        string LOG_TAG { get; }
    }

    public abstract class ILogSystem : IManager
    {
        public ILogSystem()
        {
            _instance = this;
        }

        protected static ILogSystem _instance = null;

        public static ILogSystem instance
        {
            get { return _instance; }
        }

        public abstract void Log(object obj);

        public abstract void Log(string message);

        public abstract void Log(string format, params object[] args);

        public abstract void LogWarning(object obj);

        public abstract void LogWarning(string message);

        public abstract void LogWarning(string format, params object[] args);

        public abstract void LogError(object obj);

        public abstract void LogError(string message);

        public abstract void LogError(string format, params object[] args);
    }
}
