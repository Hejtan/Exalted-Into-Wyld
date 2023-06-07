using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapGenerator : MonoBehaviour
{
    [SerializeField]
    private Tilemap floorTilemap;
    private TileBase floorTile;

    public void PaintFloorTiles(IEnumerable<Vector2Int> floorPositions) {
        PaintTiles(floorPositions, floorTilemap, floorTile);
    }
    private void PaintTiles(IEnumerable<Vector2Int> positions, Tilemap tilemap, TileBase tileBase) {
        foreach(var position in positions) {
            PaintSingleTile(tilemap, tileBase, position);
        }
        
    }
    private void PaintSingleTile(Tilemap tilemap, TileBase tileBase, Vector2Int position) {
        var tilePosition = tilemap.WorldToCell((Vector3Int)position);
        tilemap.SetTile(tilePosition, tileBase);
    }
}
