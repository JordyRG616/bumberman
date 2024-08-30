using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Essa classe representa o buraco onde o jogador tem que cair, além de contar o tempo que o jogador demorou 
// para terminar a fase. 
public class GoodHole : MonoBehaviour
{
    // Estamos guardando aqui o valor do tempo que se passou.
    private float timeCounter;


    void Update()
    {
        // Todo frame, somamos Time.deltaTime ao valor de timeCounter. Time.deltaTime representa o tempo
        // entre dois frames. Se todo frame eu somo isso ao timeCounter, estou contando quanto tempo
        // se passou no total.
        timeCounter += Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Destroy(other.gameObject);
            Debug.Log(timeCounter);
        }
    }
}
