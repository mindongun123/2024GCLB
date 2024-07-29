using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardSO", menuName = "Data/CardSO", order = 1)]
public class CardSO : ScriptableObject
{
    public Sprite _sprite;
    public List<Vector2Int> path = new List<Vector2Int>();

    // khi load tu excel thi se duoc chuoi +1 -1 +0 -1 chang han -> tuc la nhan duoc 2 vi tri : (x, y) (+1, -1) va (x, y) (+0, -1) theo diem dau x(0,0)
    // dua no vao list path
    public void ConvertPathFromExcel()
    {

    }

    public int _mana;
}