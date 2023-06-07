using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


[CreateAssetMenu(fileName="TheBiomeSO_",menuName = "DungeonGen/Biome")]

public class TileBiomeSO : ScriptableObject
{
    public List<TileBase> floorTile, wallTop;
}
