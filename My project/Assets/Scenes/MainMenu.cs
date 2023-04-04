using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
   

    //public GameObject settingsPanel;


    // Start is called before the first frame update
/*    public void onNewGameClicked()
    {
        DisableMenuButtons();
        DataPersistenceManager.instance.NewGame();
        SceneManager.LoadSceneAsync(1);
    }*/
    public void onLoadGameClicked()
    {
        

        //DataPersistenceManager.instance.LoadGame();
        SceneManager.LoadSceneAsync(1);
    }


    //Exit Game is called once per frame
    public void ExitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();

    }

}
