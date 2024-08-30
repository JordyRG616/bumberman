using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Spike : MonoBehaviour
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

    void OnTriggerEnter2D(Collider2D other)
    {
        Time.timeScale = 0;

        Invoke("ResetGame", 1f);
        ResetGame();
    }

    private void ResetGame()
    {
        SceneManager.LoadScene("New Scene");
        Time.timeScale = 1;
    }
}
