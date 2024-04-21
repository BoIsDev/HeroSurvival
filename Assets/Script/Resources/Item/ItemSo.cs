using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Item", menuName = "SO/Itemes")]
public class ItemSO : ScriptableObject
{   
    
    public ItemCode itemCode = ItemCode.NoItem;
    public string itemName = "Item";

    public int valueExp = 1;

    

}
