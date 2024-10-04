using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class ParticleCollision : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private Camera cam;
    private Vector3 ogPos;


    void Start()
    {
        cam = Camera.main;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        ogPos = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            var mousePos = Input.mousePosition;

            transform.position = mousePos;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = ogPos;
    }
}