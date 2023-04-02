using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NPCdialog : MonoBehaviour
{
    public GameObject diaglogPanel;
    public TextMeshProUGUI dialogText;

    public GameObject BuyButton;
    public GameObject NoButton;
    public bool playerIsClose;

    void Update()
    {
        if((Input.GetKeyDown(KeyCode.F))&&playerIsClose)
        {
            diaglogPanel.SetActive(true);
 
        }
    }

    public void EnterShop()
    {
        SceneManager.LoadScene(2);
    }

    public void CloseDialog()
    {
        diaglogPanel.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            print("hint");
            playerIsClose = true;
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
       
            playerIsClose = false;
       
    }
}
