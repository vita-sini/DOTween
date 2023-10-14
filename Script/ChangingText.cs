using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingText : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;

    private void Start()
    {
        _text1.DOText("���������", 5);
        _text2.DOText("���������", 15).SetRelative();
        _text3.DOText("���������", 5, true, ScrambleMode.All);
        _text3.DOColor(Color.green, 5);
    }
}
