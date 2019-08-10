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
        GameMgr mGameMgr = new GameMgr();

        // Start is called before the first frame update
        void Start()
        {
            mGameMgr.DoInit();
        }

        // Update is called once per frame
        void Update()
        {
            mGameMgr.DoUpdate();
        }

        private void OnDestroy()
        {
            mGameMgr.DoDestroy();
        }
    }
}
