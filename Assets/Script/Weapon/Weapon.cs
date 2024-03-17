using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapons
{
    string GetNameWeapons { get;  }
    float Dame{ get;  }
    float GetSpeed{ get; }

    void ProssetBullet();

}
