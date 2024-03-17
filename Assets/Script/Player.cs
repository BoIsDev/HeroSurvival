using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterManager _characterManager;
    private WeaponManager _weaponManager;

    private bool _hasSelectedCharacter = false;

    private void Start()
    {
        _characterManager = FindObjectOfType<CharacterManager>();
        _weaponManager = FindObjectOfType<WeaponManager>();
    }

    private void Update()
    {
        if (!_hasSelectedCharacter)
        {
            CheckCharacterSelection();
            return; // Ngừng thực hiện các lệnh trong Update nếu chưa chọn nhân vật
        }

        CheckWeaponSelection();
      
    }

    private void CheckCharacterSelection()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _characterManager.SelectCharacter(0);
            _hasSelectedCharacter = true;
            _weaponManager.AddWeapons("sword");
            _characterManager.GetInforCharacter();

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _characterManager.SelectCharacter(1);
            _hasSelectedCharacter = true;
            _weaponManager.AddWeapons("magic");
            _characterManager.GetInforCharacter();

        }
    }

    private void CheckWeaponSelection()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            _weaponManager.AddWeapons("sword");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            _weaponManager.AddWeapons("magic");
        }
    }
}
