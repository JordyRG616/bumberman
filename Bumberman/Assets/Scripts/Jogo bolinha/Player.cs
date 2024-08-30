using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static Player _instance;

    void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    public static Player GetInstance()
    {
        return _instance;
    }

    public void Method()
    {
        
    }
}

[System.Serializable]
public struct PlayerData
{
    public string name;
    public int level;
    public int power;

    public PlayerData(string name, int level, int power)
    {
        this.name = name;
        this.level = level;
        this.power = power;
    }
}