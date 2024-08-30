using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Classe usada para a chave. Uma vez que o jogador coletar a chave, a barreira associada é desativada.
public class Key : MonoBehaviour
{
    // Esse campo é uma referência à barreira que vai ser desativda ao se coletar a chave.
    // Lembre-se que para isso funcionar, vocês precisam arrastar o objeto em questão pra esse campo.
    [SerializeField] private GameObject barrier;


    void Start()
    {
        // Para este objeto detectar que foi coletado e não gerar resultados físicos na colisão (como bounce)
        // precisamos definir que o collisor dele é um "Trigger". É o que estamos fazendo aqui.
        var coll = GetComponent<Collider2D>();
        coll.isTrigger = true;
    }

    // OnTriggerEnter2D é uma mensagem da unity que é disparado quando um outro objeto entra na área do colisor
    // que esteja nesse objeto (chave). "other" se refere a este outro objeto, e podemos acessar propriedades
    // deste. 
    void OnTriggerEnter2D(Collider2D other)
    {
        // Estamos checando se a "tag" do nosso objeto é Player (lembre-se então de mudar a tag da bolinha).
        if(other.tag == "Player")
        {
            // Caso o objeto de fato seja a bolinha, vamos desativar a barreira.
            barrier.SetActive(false);

            // E então destruir este objeto para removê-lo da cena.
            Destroy(gameObject);
        }
    }
}
