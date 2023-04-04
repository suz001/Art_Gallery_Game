using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject PauseMenu;
    public bool isPaused;
    void Start(){
        PauseMenu.SetActive(false);
    }
    public void PauseGame(){
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void ResumeGame(){
        PauseMenu.SetActive(false);
        Time.timeScale=1f;
        isPaused = false;
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                ResumeGame();
            }
            else{
                PauseGame();
            }
        }
    }
}
