using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class FillStartingArea : MonoBehaviour
{
    public GridLayout gridLayout;
    public GameObject talkingBustPrefab;
    public GameObject magicMirrorPrefab;
    public GameObject exitPrefab;
    public GameObject chestPrefab;
    public GameObject playerPrefab;
    public void FillArea() {
        Vector3 cellSize = gridLayout.cellSize;
        Vector3 objectSize = new Vector3(cellSize.x, cellSize.y, cellSize.z);

        GameObject talkingBust = Instantiate(talkingBustPrefab, Vector3.zero, Quaternion.identity);
        talkingBust.transform.localScale = objectSize;
        MyGrid.MoveOnGrid(talkingBust, new Vector3Int(0, 4, 0));

        GameObject magicMirror = Instantiate(talkingBustPrefab, Vector3.zero, Quaternion.identity);
        magicMirror.transform.localScale = objectSize;
        MyGrid.MoveOnGrid(magicMirror, new Vector3Int(-4, -1, 0));

        GameObject exit = Instantiate(exitPrefab, Vector3.zero, Quaternion.identity);
        exit.transform.localScale = objectSize;
        MyGrid.MoveOnGrid(exit, new Vector3Int(5, 0, 0));

        GameObject chest = Instantiate(chestPrefab, Vector3.zero, Quaternion.identity);
        chest.transform.localScale = objectSize;
        MyGrid.MoveOnGrid(chest, new Vector3Int(2, -4, 0));
        
        GameObject player = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
        player.transform.localScale = objectSize;
        MyGrid.MoveOnGrid(player, new Vector3Int(0, 0, 0));
        
    }
}
