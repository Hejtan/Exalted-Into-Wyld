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

    public Transform itemContent;
    public GameObject inventoryItemPrefab;

    void Awake() {
        instance = this;
    }

    public void AddItem(AbstractItem item) {
        items.Add(item);
    }
    public void resetInventory() {
        items = new List<AbstractItem>();
        items.Add(unarmed);
    }
    
    public void ListItems() {
        foreach(Transform item in itemContent) {
            Destroy(item.gameObject);
        }
        foreach(var item in items) {
            GameObject itemObject = Instantiate(inventoryItemPrefab, itemContent);
            var itemSprite = item.icon;
            itemObject.transform.Find("Image").GetComponent<Image>().sprite = itemSprite;
        }
    }
}
