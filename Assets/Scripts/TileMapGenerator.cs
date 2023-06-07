using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapGenerator : MonoBehaviour
{
    [SerializeField]
    private Tilemap floorTilemap, wallTilemap;
    [SerializeField]
    private List<TileBase> floorTile, wallTop;

    public void PaintFloorTiles(IEnumerable<Vector2Int> floorPositions) {
        PaintTiles(floorPositions, floorTilemap, floorTile);
    }
    private void PaintTiles(IEnumerable<Vector2Int> positions, Tilemap tilemap, List<TileBase> tileBase) {
        foreach(var position in positions) {
            PaintSingleTile(tilemap, randTile(tileBase), position);
        }
    }

    public void PaintSingleBasicWall(Vector2Int position) {
        PaintSingleTile(wallTilemap, randTile(wallTop), position);
    }

    private void PaintSingleTile(Tilemap tilemap, TileBase tileBase, Vector2Int position) {
        var tilePosition = tilemap.WorldToCell((Vector3Int)position);
        tilemap.SetTile(tilePosition, tileBase);
    }

    public void Clear() {
        floorTilemap.ClearAllTiles();
        wallTilemap.ClearAllTiles();
    }

    public TileBase randTile(List<TileBase> tiles) {
        return tiles[Random.Range(0, tiles.Count)];
    }

    public void ChangeBiom(TileBiomeSO biom) {
        floorTile = biom.floorTile;
        wallTop = biom.wallTop;
    }
}
