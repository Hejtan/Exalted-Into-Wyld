using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FillMerchantArea : MonoBehaviour
{
    public GridLayout gridLayout;
    public GameObject merchantPrefab;
    public GameObject healingFountainPrefab;
    public GameObject exitPrefab;
    public HashSet<AbstractItem> itemPrefabs;
    public GameObject magicKeyPrefab;
    public GameObject playerPrefab;
    

    public void FillArea() {
        Vector3 cellSize = gridLayout.cellSize;
        Vector3 objectSize = new Vector3(cellSize.x, cellSize.y, cellSize.z);

        GameObject merchant = Instantiate(merchantPrefab, Vector3.zero, Quaternion.identity);
        merchant.transform.localScale = objectSize;
        MyGrid.MoveOnGrid(merchant, new Vector3Int(0, 3, 0));

        GameObject player = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
        player.transform.localScale = objectSize;
        MyGrid.MoveOnGrid(player, new Vector3Int(0, -2, 0));

        GameObject healingFountain = Instantiate(healingFountainPrefab, Vector3.zero, Quaternion.identity);
        healingFountain.transform.localScale = objectSize;
        MyGrid.MoveOnGrid(healingFountain, new Vector3Int(4, 4, 0));

        GameObject exit = Instantiate(exitPrefab, Vector3.zero, Quaternion.identity);
        exit.transform.localScale = objectSize;
        MyGrid.MoveOnGrid(exit, new Vector3Int(5, -1, 0));

        

        // GameObject item1 = Instantiate(itemPrefabs, Vector3.zero, Quaternion.identity);
        // player1.transform.localScale = objectSize;
        // MyGrid.MoveOnGrid(player1, new Vector3Int(0, 3, 0));
    }

    // private AbstractItem rollFromItems() {
    //     var item = itemPrefabs.ElementAt(Random.Range(0, itemPrefabs.Count));
    //     while(!item.AvailableForSpawning()) {
    //         item = itemPrefabs.ElementAt(Random.Range(0, itemPrefabs.Count));
    //     }
    //     return item;
    // }
    
}
