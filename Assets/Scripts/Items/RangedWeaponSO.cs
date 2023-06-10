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
    public override AbstractItem deepCopy() {
        RangedWeaponSO copy = new RangedWeaponSO();
        copy.value = value;
        copy.itemName = itemName;
        copy.icon = icon;
        copy.id = id;
        copy.accuracyClose = accuracyClose;
        copy.accuracyShort = accuracyShort;
        copy.accuracyMedium = accuracyMedium;
        copy.accuracyLong = accuracyLong;
        copy.accuracyExtreme = accuracyExtreme;
        copy.damage = damage;
        copy.overwhelming = overwhelming;
        copy.maxRange = maxRange;
        return copy;
    }
}
