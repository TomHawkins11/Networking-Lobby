using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameListPanel : MonoBehaviour
{
    [SerializeField] public GameObject GameButton;
    void Awake()
    {
        
    }

    private void AvailableMatchesList_OnAvailableMatchesChanged(List<MatchInfoSnapshot> matches)
    {
        ClearExistingButtons();
        CreateNewJoinGameButtons(matches);
    }


    private void ClearExistingButtons()
    {
        var buttons = GetComponentsInChildren<JoinButton>();
        foreach (var button in buttons)
        {
            Destroy(button.gameObject);
        }
    }
    private void CreateNewJoinGameButtons(List<MatchInfoSnapshot> matches)
    {
        foreach (var match in matches)
        {
            var button = Instantiate(joinButtonPrefab);
            button.Inititialize(match, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
