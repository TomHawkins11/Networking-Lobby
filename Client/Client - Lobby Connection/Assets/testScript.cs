using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class testScript : MonoBehaviour
{
    // Start is called before the first frame update
    NetworkDiscovery nd;
    void Start()
    {
        nd = gameObject.GetComponent<NetworkDiscovery>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(nd.broadcastData);
        Debug.Log(nd.broadcastKey);
        Debug.Log(nd.broadcastPort);
        Debug.Log(nd.broadcastsReceived);
    }
}
