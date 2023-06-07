using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractDungeonGenerator : MonoBehaviour
{
    [SerializeField]
    protected TileMapGenerator tileMapGenerator = null;
    [SerializeField]
    protected Vector2Int startPosition = Vector2Int.zero;

    public void GenerateDungeon(TileBiomeSO biom = null) {
        tileMapGenerator.Clear();
        RunProceduralGeneration(biom);
        
    }
    protected abstract void RunProceduralGeneration(TileBiomeSO biom = null);
}
