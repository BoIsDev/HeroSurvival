using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Sword;
    public Transform pointSword;

    private InputMoveHero inputMoveHero; // Thêm một trường inputMoveHero

    void Start()
    {
        inputMoveHero = FindObjectOfType<InputMoveHero>(); // Tìm đối tượng InputMoveHero trong scene

    }       
        


    public void Attack()
    {

    }    
}
