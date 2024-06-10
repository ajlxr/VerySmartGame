using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType { Default, Food, Weapon, Instrument }
public class ItemScriptableObject : ScriptableObject
{

    public string itemName;
    public int maximumAmount;
    public string itemDescription;
    public Sprite icon;
    public GameObject itemPrefab;


    public ItemType itemType;
}

