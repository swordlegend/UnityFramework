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
        private GameMgr mGameMgr = new GameMgr();

        private LoginModel mLoginModel = new LoginModel();

        // Start is called before the first frame update
        void Start()
        {
            mGameMgr.DoInit();
            mLoginModel.DoInit();

            NetManager.instance.SendConnect("192.168.0.108", 8888);

            StartCoroutine(Cor_SendLoginMsg());
        }

        // Update is called once per frame
        void Update()
        {
            mGameMgr.DoUpdate();
        }

        private void OnDestroy()
        {
            mLoginModel.DoClose();
            mGameMgr.DoClose();
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
