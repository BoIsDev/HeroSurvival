using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin1 : MonoBehaviour, IEnemy
{

    public string SetNameEnemy() => "Goblin1";

    public int SetHealthEnemy() => 20;

    public int SetArmorEnemy() => 5;

    public int SetExpEnemy() => 5; 

    public void SetDeadEnemy()
    {}
 

  
}
