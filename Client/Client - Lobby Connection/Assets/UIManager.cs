using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> gameButtonList;
    public GameObject GameButton;
    public GameObject lanGamesPanel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddLanGameButton(string ipAddress, string gameName)
    {
        GameObject newButton = Instantiate(GameButton);
        newButton.transform.SetParent(lanGamesPanel.transform, false);

        newButton.GetComponent<GameButton>().gameIP = ipAddress;
        newButton.GetComponent<GameButton>().gameInfo = gameName;

    }

    public void RemoveLanGames()
    {
        foreach (GameObject button in GameObject.FindGameObjectsWithTag("LanGameButton"))
        {
            Destroy(button);
        }
    }

    public void DisablePanel(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void EnablePanel(GameObject panel)
    {
        panel.SetActive(true);
    }
}
