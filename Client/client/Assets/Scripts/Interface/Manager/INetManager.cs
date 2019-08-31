using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace gtmInterface
{
    public abstract class INetManager : IManager
    {
        public INetManager()
        {
            _instance = this;
        }

        protected static INetManager _instance = null;

        public static INetManager instance
        {
            get { return _instance; }
        }



        protected GameEvent<ulong, byte[]> m_onLuaMsgEvent = new GameEvent<ulong, byte[]>();
        /// <summary>
        /// lua事件回调
        /// </summary>
        public GameEvent<ulong, byte[]> onLuaMsgEvent
        {
            get { return m_onLuaMsgEvent; }
        }

        /// <summary>
        /// 发送链接请求
        /// </summary>
        /// <param name="address"></param>
        /// <param name="port"></param>
        public abstract void SendConnect(string address, int port);

        /// <summary>
        /// 关闭连接
        /// </summary>
        public abstract void CloseSocket();

        /// <summary>
        /// 是否连接
        /// </summary>
        /// <returns></returns>
        public abstract bool IsConnected();

        /// <summary>
        /// 发送SOCKET消息
        /// </summary>
        /// <param name="buffer"></param>
        public abstract void SendMessage(ByteBuffer bytebuf);

        /// <summary>
        /// 增加事件
        /// </summary>
        /// <param name="msgid"></param>
        /// <param name="bytearray"></param>
        public abstract void AddEvent(ulong msgid, byte[] bytearray);
    }
}
