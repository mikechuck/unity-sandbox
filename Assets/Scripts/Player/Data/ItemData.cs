using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu()]
public class ItemData: ScriptableObject
{
    public string itemName;
	public GameObject itemPrefab;
	public Sprite itemImage;
	public int damage;
	public bool canEquip;
	public bool stackable;
	public bool canEat;
	public bool canUse;
	public bool canSwing;
}