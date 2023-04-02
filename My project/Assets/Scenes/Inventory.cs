using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject InventoryButton;
    public GameObject CloseButton;
    public GameObject InventoryPanel;

    public void CloseInventory()
    {
        InventoryPanel.SetActive(false);
    }

    public void OpenInventiry()
    {
        InventoryPanel.SetActive(true);
    }
}
