using gtmInterface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmGame
{
    public enum UILayer
    {
        main,
        tips,
        loading,
    }

    public class UIManager : ClientSingleton<UIManager>, LogicMgrInterface
    {
        #region 变量

        /// <summary>
        /// 对话框
        /// </summary>
        private Dictionary<int, Dialog> m_dialogDict = new Dictionary<int, Dialog>(100);

        /// <summary>
        /// 
        /// </summary>
        private Dictionary<UILayer, Transform> m_layerdict = new Dictionary<UILayer, Transform>(8);

        #endregion

        #region 继承函数

        public void DoClose()
        {
            foreach(var iter in m_dialogDict)
            {
                Dialog dialog = iter.Value;
                if (dialog == null)
                    continue;

                dialog.Close();
            }

            m_dialogDict.Clear();
        }

        public void DoInit()
        {
            InitLayer();
        }

        public void DoUpdate()
        {

        }

        #endregion

        #region 函数

        private void InitLayer()
        {
            Transform uiroot = GameObject.Find("uiroot").transform;
            if (uiroot != null)
            {
                m_layerdict.Add(UILayer.main, uiroot.Find(UILayer.main.ToString()));
                m_layerdict.Add(UILayer.tips, uiroot.Find(UILayer.tips.ToString()));
                m_layerdict.Add(UILayer.loading, uiroot.Find(UILayer.loading.ToString()));
            }
        }

        public Transform GetLayer(UILayer layer)
        {
            Transform trans;
            if (m_layerdict.TryGetValue(layer, out trans))
            {
                return trans;
            }

            return null;
        }

        public Dialog CreateDialog(string layoutname, string luafilename)
        {
            int hashcode = layoutname.GetHashCode();

            if (m_dialogDict.ContainsKey(hashcode))
                return m_dialogDict[hashcode];

            Dialog dialog = new Dialog();
            dialog.Create(layoutname);
            dialog.SetParent(UILayer.main);
            m_dialogDict.Add(hashcode, dialog);
            return dialog;
        }

        public void CloseDialog(string layoutname)
        {
            int hashcode = layoutname.GetHashCode();

            Dialog dialog = null;
            if (m_dialogDict.TryGetValue(hashcode, out dialog))
            {
                if (dialog != null)
                {
                    dialog.Close();
                }
            }

            m_dialogDict.Remove(hashcode);
        }

        #endregion





        public void SendLoginMsg()
        {
            var builder = IMsgDispatcher.instance.flatBufferBuilder;
            var account = builder.CreateString("黄河远上白云间，一片孤城万仞山。" +
                "羌笛何须怨杨柳，春风不度玉门关。秦时明月汉时关，万里长征人未还。" +
                "但使龙城飞将在，不教胡马度阴山。");
            var password = builder.CreateString("洛阳女儿对门居，才可颜容十五余。" +
                "良人玉勒乘骢马，侍女金盘脍鲤鱼。" +
                "画阁朱楼尽相望，红桃绿柳垂檐向。" +
                "罗帷送上七香车，宝扇迎归九华帐。" +
                "狂夫富贵在青春，意气骄奢剧季伦。" +
                "自怜碧玉亲教舞，不惜珊瑚持与人。" +
                "春窗曙灭九微火，九微片片飞花琐。" +
                "戏罢曾无理曲时，妆成祗是熏香坐。" +
                "城中相识尽繁华，日夜经过赵李家。" +
                "谁怜越女颜如玉，贫贱江头自浣纱。");
            fbs.ReqLogin.StartReqLogin(builder);
            fbs.ReqLogin.AddAccount(builder, account);
            fbs.ReqLogin.AddPassword(builder, password);
            var orc = fbs.ReqLogin.EndReqLogin(builder);
            builder.Finish(orc.Value);

            IMsgDispatcher.instance.SendFBMsg(fbs.ReqLogin.HashID, builder);
        }

        public void SendChatMsg()
        {
            var builder = IMsgDispatcher.instance.flatBufferBuilder;
            var say = builder.CreateString("白日依山尽，黄河入海流。欲穷千里目，更上一层楼。" +
                "红豆生南国，春来发几枝。愿君多采撷，此物最相思。" +
                "松下问童子，言师采药去。只在此山中，云深不知处。");
            fbs.ReqChat.StartReqChat(builder);
            fbs.ReqChat.AddSay(builder, say);
            var orc = fbs.ReqChat.EndReqChat(builder);
            builder.Finish(orc.Value);

            IMsgDispatcher.instance.SendFBMsg(fbs.ReqChat.HashID, builder);
        }

    }
}

