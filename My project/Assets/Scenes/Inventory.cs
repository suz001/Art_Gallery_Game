using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject InventoryButton;
    public GameObject CloseButton;
    public GameObject InventoryPanel;

    [SerializeField]
    private UIInventoryPage inventoryUI;

    public int inventorySize = 10;
    private bool isopen=false;

    private void Start()
    {
        inventoryUI.InitializeInventoryUI(inventorySize);
    }
   
    public void Update()
    {
        if (isopen == true)
        {
            if (inventoryUI.isActiveAndEnabled == false)
            {
                inventoryUI.Show();
            }
            else
            {
                inventoryUI.Hide();
            }
        }
        
    }
   public void CloseInventory()
    {
        
        isopen = false;
    }

    public void OpenInventiry()
    {
        isopen = true;


    }
}
