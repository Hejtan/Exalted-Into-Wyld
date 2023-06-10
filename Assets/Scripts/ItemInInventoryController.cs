using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInInventoryController : MonoBehaviour
{
    public void EquipThis() {
        InventoryManager.instance.EquipItem(int.Parse(gameObject.name));
    }
}
