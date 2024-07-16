using System.Collections;
using UnityEngine;

namespace MJGame.Extensions
{
    public class MJGameUILoading : MonoBehaviour, ILoading, IHelpFunction
    {
        public IEnumerator ChangeValueIE(float from, float to, float duration)
        {
            duration = Mathf.Abs(to - from) * 2.0f / 100;
            duration = Mathf.Min(Mathf.Max(duration, 1f), 2.0f);
            float timeElapsed = 0.0f;
            Debug.Log("duration: " + duration);

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