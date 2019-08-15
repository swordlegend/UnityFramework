using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmInterface;
using gtmEngine;
using gtmEngine.Net;
using FlatBuffers;

namespace gtmGame
{
    public class main : MonoBehaviour
    {
        private GameMgr m_GameMgr = new GameMgr();

        private LoginModel m_LoginModel = new LoginModel();

        public string ipaddress = "192.168.0.104";

        // Start is called before the first frame update
        void Start()
        {
            m_GameMgr.DoInit();
            m_LoginModel.DoInit();

            NetManager.instance.SendConnect(ipaddress, 8888);

            StartCoroutine(Cor_SendLoginMsg());
        }

        // Update is called once per frame
        void Update()
        {
            m_GameMgr.DoUpdate();
        }

        private void OnDestroy()
        {
            m_LoginModel.DoClose();
            m_GameMgr.DoClose();
        }

        IEnumerator Cor_SendLoginMsg()
        {
            yield return new WaitForSeconds(1.0f);

            SendLoginMsg();
        }

        private void SendLoginMsg()
        {
            // 发送消息
            var builder = new FlatBufferBuilder(1);
            var account = builder.CreateString("xieliujian");
            var password = builder.CreateString("504522");
            fbs.ReqLogin.StartReqLogin(builder);
            fbs.ReqLogin.AddAccount(builder, account);
            fbs.ReqLogin.AddPassword(builder, password);
            var orc = fbs.ReqLogin.EndReqLogin(builder);
            builder.Finish(orc.Value);
                        
            byte[] bytearray = builder.DataBuffer.ToSizedArray();
            IMsgDispatcher.instance.SendMsg((uint)fbs.MsgId.ReqLogin, bytearray);
        }
    }
}
