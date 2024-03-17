using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton1 : MonoBehaviour, IEnemy
{

    Player player;
    void Awake()
    {
        player = FindObjectOfType<Player>();
    }
    public string SetNameEnemy() => "Skeleton1";

    public int SetHealthEnemy() => 20;

    public int SetArmorEnemy() => 5;

    public void SetAttackEnemy()
    {

    }
    public int SetExpEnemy() => 5; 

    public void SetDeadEnemy()
    {

    }
}
