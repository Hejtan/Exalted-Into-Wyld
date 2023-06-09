using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private AbstractDungeonGenerator dungeonGenerator;
    [SerializeField]
    private StartingMerchantAreaGenerator startingAreaGenerator;
    [SerializeField]
    private FillStartingArea fillStartingArea;
    [SerializeField]
    private FillMerchantArea fillMerchantArea;
    [SerializeField]
    private FillCombatLevel fillDungeonArea;
    [SerializeField]
    private FillFinalBossArea fillFinalBossArea;

    [SerializeField]
    private List<TileBiomeSO> biomy;
    private int merchantFloorCounter = 0;
    [SerializeField]
    private int merchantFloorGoal = 5;
    private bool magicKey = false;
    private int depth = 0;

    public Player player;

    public GameManager instance;
    void Awake() {
        instance = this;
    }

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
            fillStartingArea.FillArea();
        } else if(magicKey) {

        } else if(merchantFloorCounter == merchantFloorGoal) {
            merchantFloorCounter = 0;
            startingAreaGenerator.GenerateDungeon();
            fillMerchantArea.FillArea();
        } else {
            merchantFloorCounter++;
            if(depth > 0) {
                PlayerStats.instance.currentXP+=5;
            }
            dungeonGenerator.GenerateDungeon(biomy[Random.Range(0, biomy.Count)]);
        }
    }

    public void finishedLevel() {
        generateLevel(false);
    }
}
