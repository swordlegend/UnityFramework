using UnityEngine;
using System.Collections.Generic;
using System;
using System.IO;
using gtmEngine.Net;
using gtmInterface;

namespace gtmEngine
{  
    public class NetManager : INetManager
    {
        #region 变量

        /// <summary>
        /// Socket
        /// </summary>
        private SocketClient mSocketClient = new SocketClient();

        /// <summary>
        /// 事件队列
        /// </summary>
        private static Queue<KeyValuePair<ushort, byte[]>> mEventQueue = new Queue<KeyValuePair<ushort, byte[]>>();
 
        #endregion

        #region 接口函数

        /// <summary>
        /// 初始化
        /// </summary>
        public override void DoInit()
        {
            if (mSocketClient == null)
                return;

            mSocketClient.OnRegister();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        public override void DoUpdate()
        {
            UpdateEventQueue();
        }

        public override void DoClose()
        {
            if (mSocketClient == null)
                return;

            mSocketClient.OnRemove();
        }

        /// <summary>
        /// 发送链接请求
        /// </summary>
        public override void SendConnect(string address, int port)
        {
            mSocketClient.SendConnect(address, port);
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        public override void CloseSocket()
        {
            mSocketClient.Close();
        }

        /// <summary>
        /// 是否连接
        /// </summary>
        /// <returns></returns>
        public override bool IsConnected()
        {
            if (mSocketClient == null)
                return false;

            return mSocketClient.IsConnected();
        }

        /// <summary>
        /// 发送SOCKET消息
        /// </summary>
        public override void SendMessage(ByteBuffer buffer)
        {
            mSocketClient.SendMessage(buffer);
        }

        /// <summary>
        /// 增加事件
        /// </summary>
        /// <param name="bytearray"></param>
        public override void AddEvent(ushort msgid, byte[] bytearray)
        {
            lock (mEventQueue)
            {
                mEventQueue.Enqueue(new KeyValuePair<ushort, byte[]>(msgid, bytearray));
            }
        }

        #endregion

        #region 函数

        /// <summary>
        /// 刷新事件队列
        /// </summary>
        private void UpdateEventQueue()
        {
            if (mEventQueue.Count <= 0)
                return;

            while (mEventQueue.Count > 0)
            {
                KeyValuePair<ushort, byte[]> keyvaleupair = mEventQueue.Dequeue();

                if (MsgDispatcher.instance != null)
                {
                    MsgDispatcher.instance.Dispatcher(keyvaleupair.Key, keyvaleupair.Value);
                }                     
            }
        }

        #endregion
    }
}


