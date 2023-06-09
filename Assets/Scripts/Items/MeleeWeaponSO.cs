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
}
