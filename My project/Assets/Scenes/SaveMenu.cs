using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SaveMenu : MonoBehaviour
{
    public void continueClicked()
    {
        SceneManager.LoadScene(1);

    }
    public void SaveGameClicked()
    {
       // DataPersistenceManager.instance.SaveGame();

    }
    public void exitClicked()
    {
        SceneManager.LoadScene(3);
    }
}
