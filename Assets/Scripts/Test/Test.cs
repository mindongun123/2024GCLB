using System.Collections;
using System.Collections.Generic;
using MJGame.Extensions;
using UnityEngine;

public class Test : MonoBehaviour
{
    [Tooltip("if Image => FillAmount Range(0,1)")]
    public float _to, _from;
    [Min(0.75f), Range(0.75f, 2f), Tooltip("Duration of the animation")]
    public float _duration;
    public MJGameImage image;
    public MJGameText text;
    public MJGameSlider slider;

    [ContextMenu("ShowSlider")]
    public void ShowSlider()
    {
        StartCoroutine(slider.ChangeValueIE(_to, _from, _duration));
    }

     [ContextMenu("ShowText")]
    public void ShowText()
    {
        StartCoroutine(text.ChangeValueIE(_to, _from, _duration));
    }
     [ContextMenu("ShowImage")]
    public void ShowImage()
    {
        StartCoroutine(image.ChangeValueIE(_to, _from, _duration));
    }
}
