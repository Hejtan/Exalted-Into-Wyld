using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AbstractDungeonGenerator dungeonGenerator;
    [SerializeField]
    private List<TileBiomeSO> biomy;
    // Start is called before the first frame update
    void Start()
    {
        
        dungeonGenerator.GenerateDungeon(biomy[Random.Range(0, biomy.Count)]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
