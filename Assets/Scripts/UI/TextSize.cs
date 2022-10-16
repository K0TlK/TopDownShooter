using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSize : MonoBehaviour
{
    [SerializeField] float deltaSize = 50.0f;
    void Start()
    {
        Sequence sequence = DOTween.Sequence();
        RectTransform rect = GetComponent<RectTransform>();
        float sizeStart = rect.sizeDelta.y;
        sequence.Append(rect.DOSizeDelta(new Vector2(0, sizeStart + deltaSize),1));
        sequence.Append(rect.DOSizeDelta(new Vector2(0, sizeStart), 1));
        sequence.SetLoops(-1, LoopType.Restart);
    }
}
