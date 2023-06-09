using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="TheRangedWeaponSO_",menuName = "DungeonGen/RangedWeapon")]
public class RangedWeaponSO : AbstractItem
{
    public override bool AvailableForSpawning() {
        return true;
    }
    public int accuracyClose;
    public int accuracyShort;
    public int accuracyMedium;
    public int accuracyLong;
    public int accuracyExtreme;
    public int damage;
    public int overwhelming;
    public int maxRange;
}
