using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitMenu : MonoBehaviour
{
    public void NewGame()
    {
        DataPersistenceManager.instance.NewGame();

    }
    public void SaveGame()
    {
        DataPersistenceManager.instance.SaveGame();
    }


    //Exit Game is called once per frame
    public void ExitGame()
    {
        SceneManager.LoadSceneAsync(0);


    }
}
