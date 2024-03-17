using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    // Tạo Character In Prefab
    
    public GameObject swordManPrefab; 
    public GameObject magicHeroPrefab;
    private GameObject _selectedCharacter = null;
    private List<GameObject> _characters = new List<GameObject>();

    private void Awake()
    {
        InitializeCharacters();
        //Set Default Character 
        foreach (GameObject character in _characters)
        {
            character.SetActive(false);
        }
    }

        // Tạo các đối tượng SwordMan và MagicHero từ prefab
   protected void InitializeCharacters()
    {
        GameObject swordManObject = Instantiate(swordManPrefab, transform.position, Quaternion.identity, transform);
        SwordMan swordMan = swordManObject.AddComponent<SwordMan>();

        GameObject magicHeroObject = Instantiate(magicHeroPrefab, transform.position, Quaternion.identity, transform);
        MagicHero magicHero = magicHeroObject.AddComponent<MagicHero>();

        // Thêm SwordMan và MagicHero vào danh sách
        _characters.Add(swordManObject);
        _characters.Add(magicHeroObject);
    }


    public void SelectCharacter(int index)
    {
        if (index >= 0 && index < _characters.Count)
        {
            for (int i = 0; i < _characters.Count; i++)
            {
                if (i == index)
                {
                    _selectedCharacter = _characters[i];
                    _selectedCharacter.SetActive(true);
                    GetInforCharacter();
                }
                else
                {
                    _characters[i].SetActive(false);
                }
            }
        }
        else
        {
            Debug.LogWarning("Character index out of range.");
        }
    }

    public void GetInforCharacter()
    {
        SwordMan swordMan = _selectedCharacter.GetComponent<SwordMan>();
        MagicHero magicHero = _selectedCharacter.GetComponent<MagicHero>();
       if (swordMan != null)
            {
                string nameHero = swordMan.SetNameCharacter();
                int healthHero = swordMan.SetHealth();
                int armorHero = swordMan.SetArmor();
                int expHero = swordMan.SetExp();
                Debug.Log("nameHero: " + nameHero + ", health: " + healthHero + ", armor: " + armorHero + ", exp: " + expHero );

            }
        else if (magicHero != null)
            {
                string nameHero = magicHero.SetNameCharacter();
                int healthHero = magicHero.SetHealth();
                int armorHero = magicHero.SetArmor();
                int expHero = magicHero.SetExp();
                Debug.Log("nameHero: " + nameHero + ", health: " + healthHero + ", armor: " + armorHero + "exp: " + expHero  );

            }

    }

    
}
