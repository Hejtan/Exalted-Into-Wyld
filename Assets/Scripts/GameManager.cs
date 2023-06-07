using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AbstractDungeonGenerator dungeonGenerator;
    public StartingMerchantAreaGenerator startingAreaGenerator;
    [SerializeField]
    private List<TileBiomeSO> biomy;
    private int merchantFloorCounter = 0;
    [SerializeField]
    private int merchantFloorGoal = 5;
    private bool magicKey = false;

    public Player player1;
    public Player player2;
    public bool twoPlayerMode = false;

    // Start is called before the first frame update
    void Start()
    {
        generateLevel(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void generateLevel(bool died) {
        if(died) {
            startingAreaGenerator.GenerateDungeon();
        } else if(magicKey) {

        } else if(merchantFloorCounter == merchantFloorGoal) {
            merchantFloorCounter = 0;
        } else {
            merchantFloorCounter++;
            player1.GainXP(5);
            if(twoPlayerMode) player2.GainXP(5);
            dungeonGenerator.GenerateDungeon(biomy[Random.Range(0, biomy.Count)]);
        }
    }

    public void finishedLevel() {
        generateLevel(false);
    }
}
