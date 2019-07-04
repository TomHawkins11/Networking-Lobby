using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NewCustomNetworkDiscovery : NetworkDiscovery
{
    public bool client = false;
    public bool server = true;
    // Start is called before the first frame update
    void Start()
    {
        
        base.Initialize();
        if (server)
        {
            
            LaunchAsServer();
        }
        else if (client)
        {
            LaunchAsClient();
        }
        else
        {
            LaunchAsServer();
        }
    }

    private void LaunchAsClient()
    {
        base.StartAsClient();
    }

    private void LaunchAsServer()
    {
        base.StartAsServer();
    }

    // Update is called once per frame
    
}
