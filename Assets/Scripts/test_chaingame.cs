using System.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using ChainGame;
using ChainGame.Ethereum;
using ChainGame.RpcObjects;
using ChainGame.Service;




public class test_chaingame : MonoBehaviour
{
     


    // Start is called before the first frame update
    void Start()
    {
        
            var liveConnection = new ConnectionOptions()
            {
                Port = "8545",
                Url = "http://localhost"
            };
            Console.WriteLine("Hello World");
            var privateConnection = new ConnectionOptions()
            {
                Port = "8545",
                Url = "http://localhost"
            };

            var ethereumService = new Web3Mobile(privateConnection);
            Debug.Log(ethereumService);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
