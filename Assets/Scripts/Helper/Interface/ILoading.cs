using System.Collections;
using TMPro;
using UnityEngine.UI;

namespace MJGame.Extensions
{
    public interface ILoading
    {
        public IEnumerator ChangeValueIE(float from, float to, float duration);
    }

    public interface ILoadingText : ILoading, IShowText
    {
        public TextMeshProUGUI text { get; set; }
    }

    public interface ILoadingSlider : ILoading
    {
        public Slider slider { get; set; }
    }

    public interface ILoadingImage : ILoading
    {
        public Image image { get; set; }
    }
}