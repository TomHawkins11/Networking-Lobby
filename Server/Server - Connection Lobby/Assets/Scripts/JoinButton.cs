using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Match;
using UnityEngine.UI;

public class JoinButton : MonoBehaviour

{
    // Start is called before the first frame update
    private Text buttonText;
    private MatchInfoSnapshot match;
    private void Awake()
    {
        buttonText = GetComponentInChildren<Text>();
        GetComponent<Button>().onClick.AddListener(JoinMatch);
    }

    
    public void Inititialize(MatchInfoSnapshot match, Transform panelTransform)
    {
        this.match = match;
        buttonText.text = match.name;
        transform.SetParent(panelTransform);
        transform.localScale = Vector3.one;
        transform.localRotation = Quaternion.identity;
        transform.localPosition = Vector3.zero;
    }

    public void JoinMatch()
    {
        FindObjectOfType<CustomNetworkManager>().JoinGame(match);
    }
}
