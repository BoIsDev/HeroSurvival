using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterManager _characterManager;

    private void Start()
    {
        // Tìm đối tượng CharacterManager trong scene
        _characterManager = FindObjectOfType<CharacterManager>();
    }

    private bool _hasSelectedCharacter = false;

    private void Update()
    {
        if (!_hasSelectedCharacter)
        {
            CheckCharacterSelection();
        }
    }

    private void CheckCharacterSelection()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _characterManager.SelectCharacter(0); // Chuyển đổi sang nhân vật có chỉ số 0
            _hasSelectedCharacter = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _characterManager.SelectCharacter(1); // Chuyển đổi sang nhân vật có chỉ số 1
            _hasSelectedCharacter = true;
        }
    }

}
