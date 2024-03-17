using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter // Quy ước đặt tên interface thường bắt đầu bằng chữ "I"
{
    string SetNameCharacter();
    int SetHealth();
    int SetArmor();

    int SetExp();

}
