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
        foreach (GameObject character in _characters)
        {
            character.SetActive(false);
        }
    }

   private void InitializeCharacters()
    {
        // Tạo các đối tượng SwordMan và MagicHero từ prefab
        GameObject swordManObject = Instantiate(swordManPrefab, transform.position, Quaternion.identity, transform);
        SwordMan swordMan = swordManObject.AddComponent<SwordMan>();

        GameObject magicHeroObject = Instantiate(magicHeroPrefab, transform.position, Quaternion.identity, transform);
        MagicHero magicHero = magicHeroObject.GetComponent<MagicHero>();

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
}
