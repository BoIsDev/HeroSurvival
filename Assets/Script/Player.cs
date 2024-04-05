using UnityEngine;

public class Player : BoDevMonoBehaviour
{
    private CharacterManager _characterManager;
    
   
    private bool _hasSelectedCharacter = false;

    protected override void Awake()
    {
        _characterManager = FindObjectOfType<CharacterManager>();
    }

    protected override void Update()
    {
        if (!_hasSelectedCharacter)
        {
            CheckCharacterSelection();
            return; // Ngừng thực hiện các lệnh trong Update nếu chưa chọn nhân vật
        }
        CheckWeaponSelection();

      
    }

    protected virtual void CheckCharacterSelection()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _characterManager.SelectCharacter(0);
            _hasSelectedCharacter = true;
            // WeaponManager.Instance.AddPoolWeapons("SwordPool", swordPool);
            _characterManager.GetInforCharacter();

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _characterManager.SelectCharacter(1);
            _hasSelectedCharacter = true;
            // WeaponManager.Instance.AddPoolWeapons("MagicPool",magicPool);
            _characterManager.GetInforCharacter();

        }
    }

    protected virtual void CheckWeaponSelection()
    {
        // if (Input.GetKeyDown(KeyCode.J))
        // {
        //     WeaponManager.Instance.AddPoolWeapons("SwordPool", swordPool);
        // }
        // if (Input.GetKeyDown(KeyCode.K))
        // {
        //     WeaponManager.Instance.AddPoolWeapons("MagicPool",magicPool);
        // }
    }
}
