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
            m_sInstance = this;
        }

        protected static ILogSystem m_sInstance = null;

        public static ILogSystem instance
        {
            get { return m_sInstance; }
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
