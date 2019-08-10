using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmInterface
{
    public interface INetManager : IManager
    {
        /// <summary>
        /// 发送链接请求
        /// </summary>
        /// <param name="address"></param>
        /// <param name="port"></param>
        void SendConnect(string address, int port);

        /// <summary>
        /// 关闭连接
        /// </summary>
        void CloseSocket();

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="obj"></param>
        void SendMessage(IMessage obj);

        /// <summary>
        /// 是否连接
        /// </summary>
        /// <returns></returns>
        bool IsConnected();
    }
}
