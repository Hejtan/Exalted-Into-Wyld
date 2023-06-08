using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public static class MyGrid
{
    public static int width;
    public static int height;
    public static Dictionary<Vector2Int, int> gridDict;
    public static float cellSize = 1;
    public static void GridGen(HashSet<Vector2Int> floorPositions) {
        gridDict = new Dictionary<Vector2Int, int>();
        int plusX = floorPositions.ElementAt(0).x;
        int minusX = floorPositions.ElementAt(0).x;
        int plusY = floorPositions.ElementAt(0).y;
        int minusY = floorPositions.ElementAt(0).y;

        foreach(var position in floorPositions) {
            if(plusX < position.x) plusX = position.x;
            else if(minusX > position.x) minusX = position.x;
            if(plusY < position.y) plusY = position.y;
            else if(minusY > position.y) minusY = position.y;
        }

        for(int i = minusX; i<=plusX; i++) {
            for(int j = minusY; j<=plusY; j++) {
                gridDict.Add(new Vector2Int(i, j), 0);
                Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i, j + 1), Color.black, 100f, false);
                Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i + 1, j), Color.white, 100f, true);
                Debug.Log("KKK " + i.ToString() + " " + j.ToString());
            }
        }

        foreach(var position in floorPositions) {
            gridDict[position] = 1;
        }


    }
    public static Vector3 GetWorldPosition(int x, int y) {
        return new Vector3(x, y) * cellSize;
    }
    public static void MoveOnGrid(GameObject gameObject, Vector3Int position) {
        gameObject.transform.position = GetWorldPosition(position.x, position.y)+ new Vector3(.5f, .5f, 0);
    }

}
