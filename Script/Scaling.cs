using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    private void Start()
    {
        transform.DOScale(new Vector3(5, 5, 5), 3).SetLoops(-1, LoopType.Yoyo);
    }
}
