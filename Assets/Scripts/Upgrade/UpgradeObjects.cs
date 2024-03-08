using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

[CreateAssetMenu]
public class UpgradeObjects : ScriptableObject
{
    public new string name;
    public string description;
    public int ID;

    public Sprite upgradeSprite;
}
