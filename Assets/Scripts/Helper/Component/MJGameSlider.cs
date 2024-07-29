using System.Collections;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace MJGame.Extensions
{
    [RequireComponent(typeof(Slider))]
    public class MJGameSlider : MJGameUI, ILoadingSlider
    {
        [ShowInInspector]
        public Slider slider { get; set; }
        public MJGameText text;

        private void OnValidate()
        {
            if (slider == null)
            {
                slider = GetComponent<Slider>();
            }
            if (text == null)
            {
                text = GetComponentInChildren<MJGameText>();
            }
        }

        private void OnEnable()
        {
            if (slider == null)
            {
                slider = GetComponent<Slider>();
            }
            if (text == null)
            {
                text = GetComponentInChildren<MJGameText>();
            }
        }

        public override void Help(float _value)
        {
            slider.value = _value;
            if (text != null)
            {
                text.TextLoading(_value.ToString());
            }
        }
    }
}