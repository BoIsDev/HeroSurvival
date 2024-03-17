using System.Collections.Generic;
using UnityEngine;

public class SwordMan : MonoBehaviour, ICharacter

{
  
     public string SetNameCharacter() => "Swordsman";
    
    public int SetHealth() => 100;
   

    public int SetArmor() => 40;
  

    public int SetExp() => 0;
   
}
