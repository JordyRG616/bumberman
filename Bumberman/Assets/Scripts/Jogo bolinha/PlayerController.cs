using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Esse script vai ser responsável pelo movimento do personagem. Neste caso, o personagem NÃO é um
// corpo físico, e portanto seu movimento pode ser feito através do transform.
public class PlayerController : MonoBehaviour
{
    // Velocidade do jogador, armazenada como float para que possa ser ajustada finamente.
    // Perceba que o atributo SerializeField 
    [SerializeField] private float speed;


    void Start()
    {
        var transform = GetComponent<Transform>();
        Player.GetInstance().Method();
    }

    void Update()
    {
        HorizontalMove();
        VerticalMove();
    }

    private void HorizontalMove()
    {
        var direction = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * direction * Time.deltaTime * speed;
    }

    private void VerticalMove()
    {
        var direction = Input.GetAxis("Vertical");
        transform.position += Vector3.up * direction * Time.deltaTime * speed;
    }
}
