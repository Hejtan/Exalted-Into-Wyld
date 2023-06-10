using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour
{
    [SerializeField]
    private Text statsText;
    [SerializeField]
    private Text xpText;

    public static StatsManager instance;
    void Awake() {
        instance = this;
    }

    public void updateStatsList() {
        string stats = "";
        stats += "Strength: " + PlayerStats.instance.strength + "\n";
        stats += "Dexterity: " + PlayerStats.instance.dexterity + "\n";
        stats += "Stamina: " + PlayerStats.instance.stamina + "\n";
        stats += "Wits: " + PlayerStats.instance.wits + "\n";
        stats += "Charisma: " + PlayerStats.instance.charisma + "\n";
        stats += "-------------------\n";
        stats += "Archery: " + PlayerStats.instance.archery + "\n";
        stats += "Brawl: " + PlayerStats.instance.brawl + "\n";
        stats += "Melee: " + PlayerStats.instance.melee + "\n";
        stats += "Thrown: " + PlayerStats.instance.thrown + "\n";
        stats += "Dodge: " + PlayerStats.instance.dodge + "\n";
        stats += "Resistance: " + PlayerStats.instance.resistance + "\n";
        stats += "Awareness: " + PlayerStats.instance.awareness + "\n";
        stats += "Stealth: " + PlayerStats.instance.stealth + "\n";
        stats += "Presence: " + PlayerStats.instance.presence + "\n";
        statsText.text = stats;

        string xp = "";
        xp += "Essence: " + PlayerStats.instance.essence + "\n\n";
        xp += "Current XP: " + PlayerStats.instance.currentXP + "\n";
        xp += "XP till Essence: " + (PlayerStats.instance.nextEssence - PlayerStats.instance.spentXP) + "\n";
        xpText.text = xp;
    }

    public void IncreaseStat(int statId) {
        switch(statId) {
            case 0:
                if(PlayerStats.instance.strength < 5 && PlayerStats.instance.currentXP >= 7) {
                    PlayerStats.instance.strength++;
                    PlayerStats.instance.spendXP(7);
                    HUDController.instance.logAction("Spent 7 XP to increase Strength to " + PlayerStats.instance.strength + ".");
                    updateStatsList();
                }
                break;
            case 1:
                if(PlayerStats.instance.dexterity < 5 && PlayerStats.instance.currentXP >= 7) {
                    PlayerStats.instance.dexterity++;
                    PlayerStats.instance.spendXP(7);
                    HUDController.instance.logAction("Spent 7 XP to increase Dexterity to " + PlayerStats.instance.dexterity + ".");
                    updateStatsList();
                }
                break;
            case 2:
                if(PlayerStats.instance.stamina < 5 && PlayerStats.instance.currentXP >= 7) {
                    PlayerStats.instance.stamina++;
                    PlayerStats.instance.spendXP(7);
                    HUDController.instance.logAction("Spent 7 XP to increase Stamina to " + PlayerStats.instance.stamina + ".");
                    updateStatsList();
                }
                break;
            case 3:
                if(PlayerStats.instance.wits < 5 && PlayerStats.instance.currentXP >= 7) {
                    PlayerStats.instance.wits++;
                    PlayerStats.instance.spendXP(7);
                    HUDController.instance.logAction("Spent 7 XP to increase Wits to " + PlayerStats.instance.wits + ".");
                    updateStatsList();
                }
                break;
            case 4:
                if(PlayerStats.instance.charisma < 5 && PlayerStats.instance.currentXP >= 7) {
                    PlayerStats.instance.charisma++;
                    PlayerStats.instance.spendXP(7);
                    HUDController.instance.logAction("Spent 7 XP to increase Charisma to " + PlayerStats.instance.charisma + ".");
                    updateStatsList();
                }
                break;
            case 5:
                if(PlayerStats.instance.archery < 5 && PlayerStats.instance.currentXP >= 5) {
                    PlayerStats.instance.archery++;
                    PlayerStats.instance.spendXP(5);
                    HUDController.instance.logAction("Spent 5 XP to increase Archery to " + PlayerStats.instance.archery + ".");
                    updateStatsList();
                }
                break;
            case 6:
                if(PlayerStats.instance.brawl < 5 && PlayerStats.instance.currentXP >= 5) {
                    PlayerStats.instance.brawl++;
                    PlayerStats.instance.spendXP(5);
                    HUDController.instance.logAction("Spent 5 XP to increase Brawl to " + PlayerStats.instance.brawl + ".");
                    updateStatsList();
                }
                break;
            case 7:
                if(PlayerStats.instance.melee < 5 && PlayerStats.instance.currentXP >= 5) {
                    PlayerStats.instance.melee++;
                    PlayerStats.instance.spendXP(5);
                    HUDController.instance.logAction("Spent 5 XP to increase Melee to " + PlayerStats.instance.melee + ".");
                    updateStatsList();
                }
                break;
            case 8:
                if(PlayerStats.instance.thrown < 5 && PlayerStats.instance.currentXP >= 5) {
                    PlayerStats.instance.thrown++;
                    PlayerStats.instance.spendXP(5);
                    HUDController.instance.logAction("Spent 5 XP to increase Thrown to " + PlayerStats.instance.thrown + ".");
                    updateStatsList();
                }
                break;
            case 9:
                if(PlayerStats.instance.dodge < 5 && PlayerStats.instance.currentXP >= 5) {
                    PlayerStats.instance.dodge++;
                    PlayerStats.instance.spendXP(5);
                    HUDController.instance.logAction("Spent 5 XP to increase Dodge to " + PlayerStats.instance.dodge + ".");
                    updateStatsList();
                }
                break;
            case 10:
                if(PlayerStats.instance.resistance < 5 && PlayerStats.instance.currentXP >= 5) {
                    PlayerStats.instance.resistance++;
                    PlayerStats.instance.spendXP(5);
                    HUDController.instance.logAction("Spent 5 XP to increase Resistance to " + PlayerStats.instance.resistance + ".");
                    updateStatsList();
                }
                break;
            case 11:
                if(PlayerStats.instance.awareness < 5 && PlayerStats.instance.currentXP >= 5) {
                    PlayerStats.instance.awareness++;
                    PlayerStats.instance.spendXP(5);
                    HUDController.instance.logAction("Spent 5 XP to increase Awareness to " + PlayerStats.instance.awareness + ".");
                    updateStatsList();
                }
                break;
            case 12:
                if(PlayerStats.instance.stealth < 5 && PlayerStats.instance.currentXP >= 5) {
                    PlayerStats.instance.stealth++;
                    PlayerStats.instance.spendXP(5);
                    HUDController.instance.logAction("Spent 5 XP to increase Stealth to " + PlayerStats.instance.stealth + ".");
                    updateStatsList();
                }
                break;
            case 13:
                if(PlayerStats.instance.presence < 5 && PlayerStats.instance.currentXP >= 5) {
                    PlayerStats.instance.presence++;
                    PlayerStats.instance.spendXP(5);
                    HUDController.instance.logAction("Spent 5 XP to increase Presence to " + PlayerStats.instance.presence + ".");
                    updateStatsList();
                }
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
