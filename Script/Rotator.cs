using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private void Start()
    {
        transform.DORotate(new Vector3(150, 150, 150), 3).SetLoops(-1, LoopType.Yoyo);
    }
}
