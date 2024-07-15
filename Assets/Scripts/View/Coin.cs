using MJGame.Extensions;
using UnityEngine;
public class Coin : MonoBehaviour
{
    public MJGameText textCoin;
    private void OnValidate()
    {
        if (textCoin == null)
        {
            textCoin = GetComponentInChildren<MJGameText>();
        }
    }
    private void OnEnable()
    {
        MJGameValuables.actionValueCoin += OnValueCoin;
        MJGameValuables.actionValueCoin?.Invoke(0);
    }

    private void OnDisable()
    {
        MJGameValuables.actionValueCoin -= OnValueCoin;
    }

    private void OnValueCoin(int _value)
    {
        textCoin.StartCoroutine(textCoin.ChangeValueIE(GameSaveCommon.Coin, GameSaveCommon.Coin + _value, 2.0f));
        GameSaveCommon.Coin += _value;
    }

    [ContextMenu("Buy")]
    public void Buy()
    {
        MJGameValuables.actionValueCoin?.Invoke(-100);
    }

    [ContextMenu("Add")]
    public void Add()
    {
        MJGameValuables.actionValueCoin?.Invoke(100);
    }
}