using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    // Prefabs của các loại vũ khí
    public GameObject swordPrefab;
    public GameObject magicPrefab;

    // Danh sách chứa các loại vũ khí
    private List<GameObject> weapons = new List<GameObject>();

    private List<GameObject> addWeaponsCurrent = new List<GameObject>();

    private GameObject swordObject;
    private GameObject magicObject;
    
    private void Awake()
    {
        // Khởi tạo các vũ khí
        InitializeWeapons();

        // Mặc định, tắt tất cả vũ khí
        foreach (GameObject weapon in weapons)
        {
            weapon.SetActive(false);   
        }

    }

    protected void InitializeWeapons()
    {
        // Tạo vũ khí Sword
        swordObject = Instantiate(swordPrefab, transform.position, Quaternion.identity, transform);
        Sword sword = swordObject.GetComponent<Sword>();

        // Tạo vũ khí Magic
        magicObject = Instantiate(magicPrefab, transform.position, Quaternion.identity, transform);
        Magic magic = magicObject.GetComponent<Magic>();

        // Thêm vũ khí vào danh sách
        weapons.Add(swordObject);
        weapons.Add(magicObject);
    }

    public void AddWeapons(string weaponName)
    {   
        if(weaponName == "sword")
        {
            addWeaponsCurrent.Add(swordObject);
            swordObject.SetActive(true);
        }
        
        if(weaponName == "magic")
        {
            addWeaponsCurrent.Add(magicObject);
            magicObject.SetActive(true);
        }
    }
}
