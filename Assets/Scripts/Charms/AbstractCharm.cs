using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="TheCharmSO_",menuName = "DungeonGen/Charm")]
public class AbstractCharm : ScriptableObject
{
    public int id, essenceRequirement, attributeRequirement, moteCost, step;
    public string charmName, description;
    public enum CharmType { Simple, Reflexive, Permanent };
    public CharmType charmType;
    public enum RequiredAttribute { Strength, Dexterity, Stamina, Wits, Charisma};
    public RequiredAttribute requiredAttribute;
    public List<AbstractCharm> charmsRequirements;

    public bool RequirementsMet() {
        foreach(AbstractCharm charm in charmsRequirements) {
            if(!PlayerStats.instance.HasCharm(charm)) {
                return false;
            }
        }
        if(PlayerStats.instance.essence < essenceRequirement) {
            return false;
        }
        switch(requiredAttribute) {
            case RequiredAttribute.Strength:
                if(PlayerStats.instance.strength < attributeRequirement) {
                    return false;
                }
                break;
            case RequiredAttribute.Dexterity:
                if(PlayerStats.instance.dexterity < attributeRequirement) {
                    return false;
                }
                break;
            case RequiredAttribute.Stamina:
                if(PlayerStats.instance.stamina < attributeRequirement) {
                    return false;
                }
                break;
            case RequiredAttribute.Wits:
                if(PlayerStats.instance.wits < attributeRequirement) {
                    return false;
                }
                break;
            case RequiredAttribute.Charisma:
                if(PlayerStats.instance.charisma < attributeRequirement) {
                    return false;
                }
                break;
        }
        return true;
    }
}
