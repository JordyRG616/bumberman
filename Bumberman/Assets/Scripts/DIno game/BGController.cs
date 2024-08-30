using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour
{
    [SerializeField] private float speed;

    private Vector3 initialPos;


    void Start()
    {
        initialPos = transform.position;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;        
    }

    void OnBecameInvisible()
    {
        transform.position = initialPos;
    }
}
