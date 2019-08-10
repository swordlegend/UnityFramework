using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmInterface;
using gtmEngine;
using gtmEngine.Net;

namespace gtmGame
{
    public class main : MonoBehaviour
    {
        //NetManager netmgr = new NetManager();

        INetManager netmgr = new NetManager();

        ILogSystem logsystem = new LogSystem();

        // Start is called before the first frame update
        void Start()
        {
            logsystem.Log("11111111111111");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
