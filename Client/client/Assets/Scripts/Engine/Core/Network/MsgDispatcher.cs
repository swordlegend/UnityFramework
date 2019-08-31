using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmInterface;
using System;
using gtmEngine.Net;
using FlatBuffers;
using System.Reflection;

namespace gtmEngine
{
    class FlatBufferProcFun<T> : IFlatBufferProcFun where T : struct, FlatBuffers.IFlatbufferObject
    {
        private MsgProcDelegate<T> m_dlg;

        private T m_obj = default(T);

        public FlatBufferProcFun(MsgProcDelegate<T> dlg)
        {
            m_dlg = dlg;
        }

        public override void Invoke(byte[] bytearray)
        {
            FlatBuffers.ByteBuffer buf = new FlatBuffers.ByteBuffer(bytearray);
            m_obj.__init(buf.GetInt(buf.Position) + buf.Position, buf);
            
            try
            {
                m_dlg(m_obj);
            }
            catch (Exception e)
            {
                LogSystem.instance.LogError(LogCategory.GameEngine, "process msg error!" + typeof(T).FullName);
                LogSystem.instance.LogError(LogCategory.GameEngine, e.ToString());
            }
        }
    }

    public class MsgDispatcher : IMsgDispatcher
    {
        #region 变量

        /// <summary>
        /// fb消息句柄
        /// </summary>
        private Dictionary<ulong, IFlatBufferProcFun> m_fbMsgProcDict = new Dictionary<ulong, IFlatBufferProcFun>(100);


        private FlatBuffers.FlatBufferBuilder m_flatBufferBuilder = new FlatBuffers.FlatBufferBuilder(1024);
        /// <summary>
        /// flatBufferBuilder
        /// </summary>
        public override FlatBuffers.FlatBufferBuilder flatBufferBuilder
        {
            get
            {
                m_flatBufferBuilder.Clear();
                return m_flatBufferBuilder;
            }
        }

        #endregion

        #region 继承

        public override void Dispatcher(ulong msgid, byte[] bytearray)
        {
            if (m_MsgType == IMsgType.FlatBuffer)
            {
                DispatcherFbMsg(msgid, bytearray);
            }
        }

        public override void DoClose()
        {
            m_fbMsgProcDict.Clear();
        }

        public override void DoInit()
        {
            
        }

        public override void DoUpdate()
        {
            
        }
        public override void RegisterFBMsg<T>(MsgProcDelegate<T> fbfunc)
        {
            Type type = typeof(T);
            FieldInfo fieldInfo = type.GetField("HashID", BindingFlags.Static | BindingFlags.Public);
            ulong hashid = (ulong)fieldInfo.GetValue(null);

            IFlatBufferProcFun exist;
            if (m_fbMsgProcDict.TryGetValue(hashid, out exist))
            {
                ILogSystem.instance.LogError(LogCategory.GameEngine, "FBMsgProc Exist! " + type.Name);
            }
            else
            {
                m_fbMsgProcDict.Add(hashid, new FlatBufferProcFun<T>(fbfunc));
            }
        }

        public override void UnRegisterFBMsg<T>(MsgProcDelegate<T> fbfunc)
        {
            Type type = typeof(T);
            FieldInfo fieldInfo = type.GetField("HashID");
            ulong hashid = (ulong)fieldInfo.GetValue(null);

            m_fbMsgProcDict.Remove(hashid);
        }

        public override void SendFBMsg(ulong msgid, FlatBufferBuilder builder)
        {
            // 这里做了优化处理，不从flatbuffer里面复制一份数据出来， 而是直接取数据, 减少一次拷贝
            int msgpos = builder.DataBuffer.Position;
            int msglen = builder.DataBuffer.Length - builder.DataBuffer.Position;

            gtmInterface.ByteBuffer buff = new gtmInterface.ByteBuffer();
            UInt16 lengh = (UInt16)(msglen + sizeof(ulong));
            UInt16 biglen = Converter.GetBigEndian(lengh);
            buff.WriteShort(biglen);
            buff.WriteUlong(msgid);
            buff.WriteBytes(builder.DataBuffer.RawBuffer, msgpos, msglen);


            string strout = "";
            for (int i = msgpos; i < builder.DataBuffer.RawBuffer.Length; i++)
            {
                strout = strout + builder.DataBuffer.RawBuffer[i];
            }
            LogSystem.instance.Log(LogCategory.GameEngine, strout);


            if (NetManager.instance != null)
            {
                NetManager.instance.SendMessage(buff);
            }
        }

        private void DispatcherFbMsg(ulong msgid, byte[] bytearray)
        {
            IFlatBufferProcFun procfunc;
            if (m_fbMsgProcDict.TryGetValue(msgid, out procfunc))
            {
                procfunc.Invoke(bytearray);
            }
        }

        #endregion
    }
}













// 这个是从flatbuffer里面复制一份数据出来
//byte[] bytearray = builder.DataBuffer.ToSizedArray();

//gtmInterface.ByteBuffer buff = new gtmInterface.ByteBuffer();
//UInt16 lengh = (UInt16)(bytearray.Length + sizeof(ulong));
//UInt16 biglen = Converter.GetBigEndian(lengh);
//buff.WriteShort(biglen);
//buff.WriteUlong(msgid);
//buff.WriteBytes(bytearray);
