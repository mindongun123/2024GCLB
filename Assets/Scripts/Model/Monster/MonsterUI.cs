using System.Collections;
using System.Collections.Generic;
using MJGame.Extensions;
using UnityEngine;
using UnityEngine.UI;

public class MonsterUI : MonoBehaviour
{
    public MJGameSlider _healthSlider;

    [SerializeField] Sprite[] sprites;
    public Image imageStateCurrent;// sau nay tu them vao Object the hien trang thai cua monster

    public void UpdateStateMonster(int _state)
    {
        imageStateCurrent.sprite = sprites[_state];
    }

    public IEnumerator UpdateHealth(int _health, int _to)
    {
        yield return _healthSlider.StartCoroutine(_healthSlider.ChangeValueIE(_health, _to, 1f));
        Debug.Log("EffectUpdateHealth");

    }
}