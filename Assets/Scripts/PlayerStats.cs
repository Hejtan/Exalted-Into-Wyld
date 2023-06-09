using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats: MonoBehaviour
{
    public static PlayerStats instance;
    public PlayerStats() {
        instance = this;
    }

    public int essence = 1, spentXP = 0, currentXP = 0, gold = 0, milestones = 0, currentMotes = 0, totalMotes = 46, nextEssence = 50,
        archery = 2, brawl = 2, melee = 2, thrown = 2, dodge = 2, resistance = 2, awareness = 2, stealth = 2, presence = 2,
        strength = 2, dexterity = 2, stamina = 2, wits = 2, charisma = 2,
        healthMax0levels = 1, healthCurrent0levels = 1, healthMax1levels = 2, healthCurrent1levels = 2,
        healthMax2levels = 2, healthCurrent2levels = 2, healthMax4levels = 1, healthCurrent4levels = 1;

    public HashSet<AbstractCharm> knownCharms = new HashSet<AbstractCharm>();

    
    public void resetCharacter() {
        essence = 1;
        spentXP = 0;
        nextEssence = 50;
        currentXP = milestones*5;
        gold = 0;
        archery = 2;
        brawl = 2;
        melee = 2;
        thrown = 2;
        dodge = 2;
        resistance = 2;
        awareness = 2;
        stealth = 2;
        presence = 2;
        strength = 2;
        dexterity = 2;
        stamina = 2;
        wits = 2;
        charisma = 2;
        healthMax0levels = 1;
        healthCurrent0levels = 1;
        healthMax1levels = 2;
        healthCurrent1levels = 2;
        healthMax2levels = 2;
        healthCurrent2levels = 2;
        healthMax4levels = 1;
        healthCurrent4levels = 1;
        knownCharms = new HashSet<AbstractCharm>();
        InventoryManager.instance.resetInventory();
    }

    public void spendXP(int amount) {
        spentXP += amount;
        currentXP -= amount;
        if(spentXP >= nextEssence) {
            essence++;
            nextEssence += 25*essence+25;
            totalMotes = 36 + essence*10;
        }
    }


    public int WoundPenalty() {
        if(healthCurrent4levels < healthMax4levels) return -4;
        if(healthCurrent2levels < healthMax2levels) return -2;
        if(healthCurrent1levels < healthMax1levels) return -1;
        return 0;
    }
    public string WoundPenaltyText() {
        string result = "0:";
        for(int i = 0; i < healthMax0levels; i++) {
            result += " [";
            if(i < healthCurrent0levels) {
                result += " ";
            } else {
                result += "X";
            }
            result += "]";
        }
        result += "\n1:";
        for(int i = 0; i < healthMax1levels; i++) {
            result += " [";
            if(i < healthCurrent1levels) {
                result += " ";
            } else {
                result += "X";
            }
            result += "]";
        }
        result += "\n2:";
        for(int i = 0; i < healthMax2levels; i++) {
            result += " [";
            if(i < healthCurrent2levels) {
                result += " ";
            } else {
                result += "X";
            }
            result += "]";
        }
        result += "\n4:";
        for(int i = 0; i < healthMax4levels; i++) {
            result += " [";
            if(i < healthCurrent4levels) {
                result += " ";
            } else {
                result += "X";
            }
            result += "]";
        }
        return result;
    }
}
