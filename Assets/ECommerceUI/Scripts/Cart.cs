using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Cart", menuName ="Cart")]
public class Cart : ScriptableObject
{
    public string productName;
    public string description;
    public string price;

    public Sprite productImage ;


}
