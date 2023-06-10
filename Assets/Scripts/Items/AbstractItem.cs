using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractItem : ScriptableObject
{
    public int value;
    public string itemName;
    public Sprite icon;
    public int id;

    public abstract bool AvailableForSpawning();
    public abstract AbstractItem deepCopy();
}
