using UnityEngine;
using System.Collections.Generic;
using System;
using System.IO;
using gtmEngine.Net;
using gtmInterface;

namespace gtmEngine
{
    //public delegate void TocHandler(object data);

    public class NetManager : Singleton<NetManager>, INetManager
    {
        #region 变量

        /// <summary>
        /// Socket
        /// </summary>
        private SocketClient mSocketClient = new SocketClient();

        /// <summary>
        /// 回调消息表
        /// </summary>
        //private Dictionary<Type, TocHandler> mHandlerDict = new Dictionary<Type, TocHandler>();

        /// <summary>
        /// 事件队列
        /// </summary>
        private static Queue<KeyValuePair<int, ByteBuffer>> mEventQueue = new Queue<KeyValuePair<int, ByteBuffer>>();
        
        #endregion

        #region 接口函数

        /// <summary>
        /// 初始化
        /// </summary>
        public void DoInit()
        {
            if (mSocketClient == null)
                return;

            mSocketClient.OnRegister();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        public void DoUpdate()
        {
            UpdateEventQueue();
        }

        public void DoClose()
        {
            if (mSocketClient == null)
                return;

            mSocketClient.OnRemove();
        }

        /// <summary>
        /// 发送链接请求
        /// </summary>
        public void SendConnect(string address, int port)
        {
            mSocketClient.SendConnect(address, port);
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        public void CloseSocket()
        {
            mSocketClient.Close();
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="obj"></param>
        public void SendMessage(IMessage obj)
        {

        }

        /// <summary>
        /// 是否连接
        /// </summary>
        /// <returns></returns>
        public bool IsConnected()
        {
            if (mSocketClient == null)
                return false;

            return mSocketClient.IsConnected();
        }

        #endregion

        #region 函数

        /// <summary>
        /// 发送SOCKET消息
        /// </summary>
        public void SendMessage(ByteBuffer buffer)
        {
            mSocketClient.SendMessage(buffer);
        }
        
        /// <summary>
        /// 连接 
        /// </summary>
        public void OnConnect()
        {
            LogSystem.instance.Log("======连接========");
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void OnDisConnect()
        {
            LogSystem.instance.Log("======断开连接========");
        }

        /// <summary>
        /// 增加事件
        /// </summary>
        /// <param name="_event"></param>
        /// <param name="data"></param>
        public void AddEvent(int _event, ByteBuffer data)
        {
            mEventQueue.Enqueue(new KeyValuePair<int, ByteBuffer>(_event, data));
        }

        /// <summary>
        /// 派发协议
        /// </summary>
        /// <param name="protoId"></param>
        /// <param name="buff"></param>
        //public void DispatchProto(int protoId, byte[] buff)
        //{
        //    if (!ProtoDic.ContainProtoId(protoId))
        //    {
        //        Debuger.LogError("未知协议号");
        //        return;
        //    }

        //    Type protoType = ProtoDic.GetProtoTypeByProtoId(protoId);

        //    try
        //    {
        //        MessageParser messageParser = ProtoDic.GetMessageParser(protoType.TypeHandle);
        //        object toc = messageParser.ParseFrom(buff);
        //        mEventQueue.Enqueue(new KeyValuePair<Type, object>(protoType, toc));
        //    }
        //    catch
        //    {
        //        Debuger.Log("DispatchProto Error:" + protoType.ToString());
        //    }
        //}

        //public void AddHandler(Type type, TocHandler handler)
        //{
        //    if (mHandlerDict.ContainsKey(type))
        //    {
        //        mHandlerDict[type] += handler;
        //    }
        //    else
        //    {
        //        mHandlerDict.Add(type, handler);
        //    }
        //}

        //public void RemoveHandle(Type type, TocHandler handler)
        //{
        //    if (mHandlerDict.ContainsKey(type))
        //    {
        //        mHandlerDict[type] -= handler;
        //    }
        //}

        /// <summary>
        /// 发送SOCKET消息
        /// </summary>
        //public void SendMessage(IMessage obj)
        //{
        //    if (!mSocketClient.IsConnected())
        //        return;

        //    if (!ProtoDic.ContainProtoType(obj.GetType()))
        //    {
        //        Debuger.LogError("不存协议类型");
        //        return;
        //    }

        //    ByteBuffer buff = new ByteBuffer();
        //    int protoId = ProtoDic.GetProtoIdByProtoType(obj.GetType());

        //    byte[] result;
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        obj.WriteTo(ms);
        //        result = ms.ToArray();
        //    }

        //    UInt16 lengh = (UInt16)(result.Length + 2);
        //    //Debug.Log("lengh" + lengh + ",protoId" + protoId);
        //    buff.WriteShort((UInt16)lengh);
        //    buff.WriteShort((UInt16)protoId);
        //    buff.WriteBytes(result);
        //    SendMessage(buff);
        //}

        /// <summary>
        /// 刷新事件队列
        /// </summary>
        private void UpdateEventQueue()
        {
            if (mEventQueue.Count <= 0)
                return;

            while (mEventQueue.Count > 0)
            {
                KeyValuePair<int, ByteBuffer> _event = mEventQueue.Dequeue();
                            
            }
        }

        #endregion

    }
}


