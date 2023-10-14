using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    private void Start()
    {
        transform.DOMove(new Vector3(-26, 3, -20), 3).SetLoops(-1, LoopType.Yoyo);
    }
}
