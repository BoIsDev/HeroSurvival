using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Enemy", menuName = "SO/Enemies")]
public class EnemySO : ScriptableObject
{
    public string enemyName = "Enemy";
    public int hpMax = 10;  

    public List<DropRate> dropList;
}
