using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    [SerializeField] private GameObject _inventoryPanel;

    public void OpenInventory()
    {
        _inventoryPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseInventory()
    {
        _inventoryPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
