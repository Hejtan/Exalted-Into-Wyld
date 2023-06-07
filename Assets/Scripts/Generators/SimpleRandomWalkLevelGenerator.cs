using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using System.Linq;

public class SimpleRandomWalkLevelGenerator : AbstractDungeonGenerator
{

    [SerializeField]
    protected SimpleRandomWalkSO randomWalkParemeters;


    protected override void RunProceduralGeneration(TileBiomeSO biom = null) {
        HashSet<Vector2Int> floorPositions = RunRandomWalk(randomWalkParemeters, startPosition);
        if(biom != null) {
            tileMapGenerator.ChangeBiom(biom);
        }
        tileMapGenerator.PaintFloorTiles(floorPositions);
        WallGenerator.CreateWalls(floorPositions, tileMapGenerator);
    }

    protected HashSet<Vector2Int> RunRandomWalk(SimpleRandomWalkSO randomWalkParemeters, Vector2Int position) {
        var currentPosition = position;
        HashSet<Vector2Int> floorPositions = new HashSet<Vector2Int>();
        for(int i=0; i<randomWalkParemeters.iterations; i++) {
            var path = ProceduralGeneration.SimpleRandomWalk(currentPosition, randomWalkParemeters.walkLength);
            floorPositions.UnionWith(path);
            if(randomWalkParemeters.startRandomlyEachIteration) {
                currentPosition = floorPositions.ElementAt(Random.Range(0, floorPositions.Count));
            }
        }
        return floorPositions;
    }
}
