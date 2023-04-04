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
    public GameObject shopPanel;
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.F))&&playerIsClose)
        {
            diaglogPanel.SetActive(true);
 
        }
    }

    public void EnterShop()
    {
        diaglogPanel.SetActive(false);
        shopPanel.SetActive(true);
    }

    public void CloseDialog()
    {
        diaglogPanel.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {

            playerIsClose = true;
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
       
            playerIsClose = false;
       
    }
}
