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

    public GameObject Instruction;

<<<<<<< Updated upstream
    private void Starat(){
        Instruction.SetActive(false);
    }

=======
    
    public GameObject shopPanel;
>>>>>>> Stashed changes
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.F))&&playerIsClose)
        {
            diaglogPanel.SetActive(true);
 
        }
    }
    private void Start(){
        Instruction.SetActive(false);
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
            Instruction.SetActive(true);

        }
        DataPersistenceManager.instance.SaveGame();
    }


    private void OnTriggerExit2D(Collider2D other)
    {
       
        playerIsClose = false;
        Instruction.SetActive(false);
    }
}
