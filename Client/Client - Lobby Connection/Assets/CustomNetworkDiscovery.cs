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
    [SerializeField] public GameObject GameButton;

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
            GameObject newButton = Instantiate(GameButton);
            newButton.transform.SetParent(lanGamesPanel.transform, false);

            Debug.Log(value.serverAddress);
            Debug.Log(System.Text.Encoding.Unicode.GetString(value.broadcastData));
        }
    }

    public override void OnReceivedBroadcast(string fromAddress, string data)
    {
        fromText.GetComponent<Text>().text = fromAddress;
        dataText.GetComponent<Text>().text = data;
    }
}
