using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace MJGame.Extensions
{
    public class MJGameUI : MonoBehaviour, ILoading, IHelpFunction
    {
        public IEnumerator ChangeValueIE(float from, float to, float duration)
        {

            duration = Mathf.Abs(to - from) * 2.0f / 100;
            duration = Mathf.Min(Mathf.Max(duration, 1f), 2.0f);
            float timeElapsed = 0.0f;

            while (timeElapsed < duration)
            {
                timeElapsed += Time.deltaTime;

                float value = (float)Mathf.Lerp(from, to, timeElapsed / duration);

                Help(value);

                yield return null;
            }
        }
        public virtual void Help(float _value)
        {
        }
    }
}