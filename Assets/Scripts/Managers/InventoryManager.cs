using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public List<AbstractItem> items = new List<AbstractItem>();
    [SerializeField]
    private AbstractItem unarmed;
    private int weaponEquipped = 0;
    private int armorEquipped = -1;
    private int idCounter = 1;


    public Transform itemContent;
    public GameObject inventoryItemPrefab;

    void Awake() {
        instance = this;
    }

    public void AddItem(AbstractItem item) {
        var newitem = item.deepCopy();
        newitem.id = idCounter++;
        items.Add(newitem);
    }
    public void resetInventory() {
        items = new List<AbstractItem>();
        idCounter = 0;
        weaponEquipped = 0;
        armorEquipped = -1;
        AddItem(unarmed);
    }
    
    public void ListItems() {
        foreach(Transform item in itemContent) {
            Destroy(item.gameObject);
        }
        foreach(var item in items) {
            GameObject itemObject = Instantiate(inventoryItemPrefab, itemContent);
            itemObject.name = item.id.ToString();
            var itemSprite = item.icon;
            itemObject.transform.Find("Image").GetComponent<Image>().sprite = itemSprite;
            if (item.id == weaponEquipped || item.id == armorEquipped) {
                itemObject.GetComponent<Image>().color = Color.cyan;
            }
        }
    }

    public void EquipItem(int id) {
        if (items[id].GetType() == typeof(MeleeWeaponSO) || items[id].GetType() == typeof(RangedWeaponSO)) {
            weaponEquipped = id;
            HUDController.instance.logAction("You equipped a weapon.");
        } else if (items[id].GetType() == typeof(ArmorSO)) {
            armorEquipped = id;
            HUDController.instance.logAction("You equipped an armor.");
        }
        ListItems();
    }
}
