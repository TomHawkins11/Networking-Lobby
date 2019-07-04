using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class testScript : MonoBehaviour
{
    // Start is called before the first frame update
    NewCustomNetworkDiscovery nd;
    void Start()
    {
        nd = gameObject.GetComponent<NewCustomNetworkDiscovery>();
        StartCoroutine(OutputData());
    }

    // Update is called once per frame
    void Update()
    {

        
        

    }

    IEnumerator OutputData()
    {
        while (true)
        {
            Debug.Log(nd.broadcastData);
            Debug.Log(nd.broadcastKey);
            Debug.Log(nd.broadcastPort);

            yield return new WaitForSeconds(5f);
        }
       
    }
}
