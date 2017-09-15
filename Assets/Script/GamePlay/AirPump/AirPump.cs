using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;

public class AirPump : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        var position = _pumpImage.position;
        position.y = eventData.position.y;

        _pumpImage.position = position;
    }

    private void Start()
    {
        Assert.IsNotNull(_pumpImage);
    }


    private void Update()
    {

    }

    [SerializeField]
    private Transform _pumpImage = null;
}
