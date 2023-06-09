using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public List<AbstractItem> items;
    public static int chanceForArtifact = 20;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var artifact = Random.Range(0, Mathf.Max(chanceForArtifact, 1));
            AbstractItem item;
            if (artifact == 0) {
                item = items[Random.Range(0, items.Count/2)];
            }
            else {
                item = items[Random.Range(items.Count/2, items.Count)];
            }
            InventoryManager.instance.AddItem(item);
            HUDController.instance.logAction("The chest contained " + item.name + ".");
            Destroy(gameObject);
        }
    }
}
