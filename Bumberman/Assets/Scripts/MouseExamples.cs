using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseExamples : MonoBehaviour
{
    [SerializeField] private Color clickedColor;
    private SpriteRenderer spriteRenderer;
    private Camera cam;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        cam = Camera.main;
    }

    void OnMouseDrag()
    {
        // Obtém a posição do mouse armazenada na classe Input.
        var mousePos = Input.mousePosition;

        // Faz a conversão entre espaço de tela e espaço de mundo.
        var position = cam.ScreenToWorldPoint(mousePos);

        // Durante a conversão, a posição z é definida como -10 (posição z da câmera).
        // Precisamos fazer esse valor ser 0 para o objeto poder ser visto pela câmera.
        position.z = 0;

        // Passamos a posição que foi calculada para a posição atual deste objeto, movendo
        // este para a posição atual do ponteiro do mouse.
        transform.position = position;
    }

    void OnMouseDown()
    {
        Cursor.visible = false;
    }

    void OnMouseUp()
    {
        Cursor.visible = true;
    }

    void OnMouseExit()
    {
        
    }

    void OnMouseEnter()
    {
        
    }
}
