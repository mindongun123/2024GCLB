using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MJGame.Extensions
{

    [RequireComponent(typeof(Image))]
    public class MJGameImage : MJGameUI, ILoadingImage
    {
        public Image image { get; set; }
        public MJGameText text;

        private void OnValidate()
        {
            if (image == null)
            {
                image = GetComponent<Image>();
            }
            if (text == null)
            {
                text = GetComponentInChildren<MJGameText>();
            }
        }

        private void OnEnable()
        {
            if (image == null)
            {
                image = GetComponent<Image>();
            }
            if (text == null)
            {
                text = GetComponentInChildren<MJGameText>();
            }
        }

        public override void Help(float _value)
        {
            image.fillAmount = _value;
            if (text != null)
            {
                text.TextLoading(_value.ToString());
            }
        }
    }
}