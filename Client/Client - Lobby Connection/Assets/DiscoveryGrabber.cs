using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DiscoveryGrabber : MonoBehaviour
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
        foreach (var key in nd.broadcastsReceived.Keys)
        {
            NetworkBroadcastResult value;
            nd.broadcastsReceived.TryGetValue(key, out value);
            string stringValue = System.Text.Encoding.Unicode.GetString(value.broadcastData, 0, value.broadcastData.Length);
            Debug.Log(stringValue);
            

        }
    }
}
