using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    [SerializeField] private string _itemName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Managers.Inventory.AddItem(_itemName);
        Destroy(this.gameObject);
    }
}
