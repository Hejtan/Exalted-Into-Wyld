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

}
