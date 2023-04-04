using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsPanel;

    // Start is called before the first frame update
    public void onNewGameClicked()
    {
        //DataPersistenceManager.instance.NewGame();
    }
    public void onLoadGameClicked()
    {
        //DataPersistenceManager.instance.LoadGame();
    }


    //Exit Game is called once per frame
    public void ExitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();

    }
}
