using System.Collections.Generic;
using UnityEngine;

public class MagicHero : MonoBehaviour, ICharacter

{
    public string SetNameCharacter() => "MagicHero";
   

    public int SetHealth() => 100;
   
    public int SetArmor() => 40;
    
    public int SetExp() => 0;
 
    
  
}
