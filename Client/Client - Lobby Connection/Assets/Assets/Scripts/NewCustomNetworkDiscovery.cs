using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;

public class NewCustomNetworkDiscovery : NetworkDiscovery
{
    private Dictionary<LanConnectionInfo, float> lanAdresses = new Dictionary<LanConnectionInfo, float>();
    private float timeout = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
        base.Initialize();
        base.StartAsClient();
        
    }

    private void Update()
    {
        UpdateMatchInfos();
    }

   

    public override void OnReceivedBroadcast(string fromAddress, string data)
    {
        base.OnReceivedBroadcast(fromAddress, data);
        Debug.Log(fromAddress);
        
        LanConnectionInfo info = new LanConnectionInfo(fromAddress, data);

        if (lanAdresses.ContainsKey(info) == false)
        {
            lanAdresses.Add(info, Time.time + timeout);
            UpdateMatchInfos();
        }
        else
        {
            lanAdresses[info] = Time.time + timeout;
        }
    }

    private void UpdateMatchInfos()
    {
        foreach (var key in lanAdresses.Keys)
        {
            Debug.Log(key);
        }
        
        
    }

   

    // Update is called once per frame

}
