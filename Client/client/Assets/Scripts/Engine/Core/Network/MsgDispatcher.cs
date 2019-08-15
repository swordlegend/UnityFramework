using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmInterface;
using System;
using gtmEngine.Net;

namespace gtmEngine
{
    public class MsgDispatcher : IMsgDispatcher
    {
        #region 变量

        /// <summary>
        /// 消息句柄
        /// </summary>
        private static Dictionary<uint, IMsgProcFunc> m_Handle = new Dictionary<uint, IMsgProcFunc>();

        #endregion

        #region 继承

        public override void Dispatcher(ushort msgid, byte[] bytearray)
        {
            if (!m_Handle.ContainsKey(msgid))
                return;

            m_Handle[msgid].Invoke(bytearray);
        }

        public override void DoClose()
        {
            m_Handle.Clear();
        }

        public override void DoInit()
        {
            
        }

        public override void DoUpdate()
        {
            
        }

        public override void Register(uint msgid, IMsgProcFunc msg)
        {
            if (!m_Handle.ContainsKey(msgid))
            {
                m_Handle.Add(msgid, msg);
            }
            else
            {
                m_Handle[msgid] += msg;
            }
        }

        public override void UnRegister(uint msgid, IMsgProcFunc msg)
        {
            if (m_Handle.ContainsKey(msgid))
            {
                m_Handle[msgid] -= msg;
            }
        }

        public override void SendMsg(uint msgid, byte[] bytearray)
        {
            ByteBuffer buff = new ByteBuffer();
            UInt16 lengh = (UInt16)(bytearray.Length + 2);
            buff.WriteShort((UInt16)lengh);
            buff.WriteShort((UInt16)msgid);
            buff.WriteBytes(bytearray);

            if (NetManager.instance != null)
            {
                NetManager.instance.SendMessage(buff);
            }
        }

        #endregion
    }
}
