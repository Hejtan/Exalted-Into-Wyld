using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="TheMeleeWeaponSO_",menuName = "DungeonGen/MeleeWeapon")]
public class MeleeWeaponSO : AbstractItem
{
    public override bool AvailableForSpawning() {
        return value>0;
    }
    public int accuracy;
    public int damage;
    public int defenseBonus;
    public int overwhelming;
    public override AbstractItem deepCopy() {
        MeleeWeaponSO copy = new MeleeWeaponSO();
        copy.value = value;
        copy.itemName = itemName;
        copy.icon = icon;
        copy.id = id;
        copy.accuracy = accuracy;
        copy.damage = damage;
        copy.defenseBonus = defenseBonus;
        copy.overwhelming = overwhelming;
        return copy;
    }
}
