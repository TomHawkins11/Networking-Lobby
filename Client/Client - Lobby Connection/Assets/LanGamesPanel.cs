using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanGamesPanel : MonoBehaviour
{
    public List<GameObject> buttonList;
    public GameObject GameButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddButton(string ipAddress, string gameName) 
    {
        

            
        GameObject newButton = Instantiate(GameButton);
        newButton.transform.SetParent(gameObject.transform, false);

        newButton.GetComponent<GameButton>().gameIP = ipAddress;
        newButton.GetComponent<GameButton>().gameInfo = gameName;       
            
        
        


    }
}
