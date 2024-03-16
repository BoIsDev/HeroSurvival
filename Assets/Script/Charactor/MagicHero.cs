using System.Collections.Generic;
using UnityEngine;

public class MagicHero : MonoBehaviour, ICharacter

{
    public string GetNameCharacter()
    {
        return "Magic";
    }

    public int GetHealth()
    {
        return 100;
    }

    public int GetArmor()
    {
        return 40;
    }
    
  
}
