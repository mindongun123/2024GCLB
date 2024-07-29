using System.Collections;
using TMPro;
using UnityEngine;


namespace MJGame.Extensions
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class MJGameText : MJGameUI, IShowText, ILoadingText
    {
        public TextMeshProUGUI text
        { get; set; }

        private void OnValidate()
        {
            if (text == null)
            {
                text = GetComponent<TextMeshProUGUI>();
            }
        }

        private void OnEnable()
        {
            if (text == null)
            {
                text = GetComponent<TextMeshProUGUI>();
            }
        }
        public void TextLoading(string value)
        {
            text.text = value;
        }

        public override void Help(float _value)
        {
            TextLoading(((int)_value).ToString());
        }
    }
}