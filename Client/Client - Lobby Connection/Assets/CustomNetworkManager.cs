using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;
using UnityEngine.UI;

public class CustomNetworkManager : NetworkManager
{
    [SerializeField] private string ipAddress;

    public void HostGame()
    {
        NetworkManager.singleton.StopAllCoroutines();
        SetPort();
        NetworkManager.singleton.StartHost();
    }
    public void JoinGame()
    {
        NetworkManager.singleton.StopAllCoroutines();
        SetIPAddress();
        SetPort();
        NetworkManager.singleton.StartClient();
    }

    public void SetPort()
    {
        NetworkManager.singleton.networkPort = 7777;
    }

    public void SetIPAddress()
    {
        string ipAddress = GameObject.Find("InputField").transform.Find("Text").GetComponent<Text>().text;
        NetworkManager.singleton.networkAddress = ipAddress;
    }
}
