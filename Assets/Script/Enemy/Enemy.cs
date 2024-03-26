using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemy 
{
    string SetNameEnemy();
    int SetHealthEnemy();

    int SetArmorEnemy();

    int SetExpEnemy();

    
    void SetDeadEnemy();
}
