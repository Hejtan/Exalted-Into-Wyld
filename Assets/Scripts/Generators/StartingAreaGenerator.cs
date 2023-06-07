using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingAreaGenerator : AbstractDungeonGenerator
{
    [SerializeField]
    private int size;
    protected override void RunProceduralGeneration(TileBiomeSO biom = null) {
        HashSet<Vector2Int> floorPositions = new HashSet<Vector2Int>();
        var currentPoz = Vector2Int.zero;
        floorPositions.Add(currentPoz);
        for(int i=0; i<size; i++) {
            for(int j = 0; j < size; j++) {
                floorPositions.Add(currentPoz+ new Vector2Int(i, j));
                floorPositions.Add(currentPoz+ new Vector2Int(-i, j));
                floorPositions.Add(currentPoz+ new Vector2Int(i, -j));
                floorPositions.Add(currentPoz+ new Vector2Int(-i, -j));
            }
        }
        tileMapGenerator.PaintFloorTiles(floorPositions);
        WallGenerator.CreateWalls(floorPositions, tileMapGenerator);
    }
}
