using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RandomSceneLoader : MonoBehaviour
{
    [SerializeField] private List<string> sceneNames;
    private AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Load()
    {
        audioSource.Play();

        // int rdm = Random.Range(0, sceneNames.Count);
        // string sceneName = sceneNames[rdm];
        // SceneManager.LoadScene(sceneName);
    }

    public void Exit()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(0);
        }

        Application.Quit();
    }
}
