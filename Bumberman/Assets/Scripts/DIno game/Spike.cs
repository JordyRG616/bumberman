using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private string sceneName;

    private Vector3 initialPos;


    void Start()
    {
        initialPos = transform.position;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Time.timeScale = 0;
        StartCoroutine(ResetGame());
    }

    private IEnumerator ResetGame()
    {
        float time = 0;

        while(time < 1)
        {
            time += 0.01f;
            yield return new WaitForSecondsRealtime(0.01f);
        }

        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }

    void OnBecameInvisible()
    {
        transform.position = initialPos;
        Metodo(10);
    }

    void OnJointBreak2D(Joint2D brokenJoint)
    {
        Application.Quit();
    }

    private void Metodo(int param = 5)
    {

    }
}
 