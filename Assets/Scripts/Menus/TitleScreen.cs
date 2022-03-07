using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            StartNewGame();
        }
    }

    void StartNewGame()
    {
        AllGameData.LoadNewData();
        SceneManager.LoadScene((int)AllGameData.mapID);
    }
}
