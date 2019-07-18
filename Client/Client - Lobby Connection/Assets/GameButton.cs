using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameButton: MonoBehaviour
{
    public string gameIP = "";
    public string gameInfo = "";

    public GameObject textIP;
    public GameObject textInfo;
    CustomNetworkManager cnm;
    
    // Start is called before the first frame update
    void Start()
    {
        textIP = gameObject.transform.Find("GameIP").gameObject;
        textInfo = gameObject.transform.Find("GameName").gameObject;

        textInfo.GetComponent<Text>().text = gameInfo;
        textIP.GetComponent<Text>().text = gameIP;

        cnm = GameObject.Find("Client").GetComponent<CustomNetworkManager>();

    }

    public void ConnectToGame()
    {
        cnm.JoinGame(gameIP);
    }

    // Update is called once per frame
    
}
