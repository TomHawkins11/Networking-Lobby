using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class CustomNetworkDiscovery : NetworkDiscovery
{
    // Start is called before the first frame update
    public bool client;
    public GameObject fromText;
    public GameObject dataText;
    public GameObject lanGamesPanel;
    

    public void Start()
    {
        StartClient();
        fromText = GameObject.Find("GameName");
        dataText = GameObject.Find("GameIP");
        lanGamesPanel = GameObject.Find("LanGamesPanel");
    }

    public void StartHost()
    {
        if (running)
        {
            StopBroadcast();
            Initialize();
        }
        StartAsServer();
    }

    // Update is called once per frame
    

    public void StartClient()
    {
        if (running || !running)
        {
            StopBroadcast();
            Initialize();
        }
        StartAsClient();
        RefreshAvailableGames();
    }

    public void RefreshAvailableGames()
    {
        
        foreach (var value in broadcastsReceived.Values)
        {
            string ip = value.serverAddress.Substring(7);
            string name = System.Text.Encoding.Unicode.GetString(value.broadcastData);

            Debug.Log(value.serverAddress);
            Debug.Log(System.Text.Encoding.Unicode.GetString(value.broadcastData));
            lanGamesPanel.GetComponent<LanGamesPanel>().AddButton(ip , name);
        }

        
    }

    
}
