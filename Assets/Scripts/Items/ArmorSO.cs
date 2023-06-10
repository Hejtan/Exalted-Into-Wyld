using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="TheArmorSO_",menuName = "DungeonGen/Armor")]
public class ArmorSO : AbstractItem
{
    public override bool AvailableForSpawning() {
        return true;
    }
    public int soak;
    public int hardness;
    public int mobilityPenalty;
    public override AbstractItem deepCopy() {
        ArmorSO copy = new ArmorSO();
        copy.value = value;
        copy.itemName = itemName;
        copy.icon = icon;
        copy.id = id;
        copy.soak = soak;
        copy.hardness = hardness;
        copy.mobilityPenalty = mobilityPenalty;
        return copy;
    }

}
