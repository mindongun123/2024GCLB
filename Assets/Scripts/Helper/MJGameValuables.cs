using UnityEngine.Events;
namespace MJGame.Extensions
{
    public static class MJGameValue
    {
        public static UnityAction<int> OnValueChanged = null;
        public static int ValueCoin;
    }

    public static class MJGameValuables
    {
        public static void Reset(UnityAction<int> action, int Value)
        {
            Value = 0;
            action?.Invoke(Value);
        }

        public static void ChangeValue(UnityAction<int> action, int Value, int value)
        {
            Value += value;
            action?.Invoke(Value);
        }
    }
}