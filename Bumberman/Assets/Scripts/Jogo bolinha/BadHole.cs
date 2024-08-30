using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

// Essa classe vai representar os buracos que o jogador quer evitar. Quando o jogador cair em um deles,
// a bola vai voltar para sua posição inicial.
public class BadHole : MonoBehaviour
{
    // Passamos como referência o objeto que representa a bola. Perceba que estamos usando um campo
    // do tipo Transform porque sabemos que vamos precisar alterar informações espaciais da bola.
    [SerializeField] private Transform ball;

    // Como vamos precisar retornar a bola para o posição inicial, precisamos que o buraco lembre qual
    // era a posição dela no início do jogo. Vamos salvar essa posição nessa variável.
    private Vector3 initialPos;


    void Start()
    {
        // No início do jogo, pegamos o valor da posição da bola e definimos ela como a posição para qual
        // a bolinha vai retornar ao cair nesse buraco.
        initialPos = ball.position;
    }

    // OnTriggerEnter2D é uma mensagem da unity que é disparado quando um outro objeto entra na área do colisor
    // que esteja nesse objeto (buraco). "other" se refere a este outro objeto, e podemos acessar propriedades
    // deste. 
    void OnTriggerEnter2D(Collider2D other)
    {

        // Estamos checando se a "tag" do nosso objeto é Player (lembre-se então de mudar a tag da bolinha).
        if(other.tag == "Player")
        {
            // Caso o objeto de fato seja a bolinha, vamos mover ela para a posição inicial da bola.
            ball.position = initialPos;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene(0);
    }
}
