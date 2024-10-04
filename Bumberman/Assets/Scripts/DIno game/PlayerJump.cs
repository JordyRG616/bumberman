using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private KeyCode key;
    [SerializeField] private float jumpForce = 1.4f;

    private float effectiveJumpForce;
    private Rigidbody2D body;
    private bool jumping;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(jumping) return;

        if(Input.GetKey(key))
        {
            effectiveJumpForce += Time.deltaTime * 100;
        }

        if(Input.GetKeyUp(key))
        {
            Jump();
        }
    }

    private void Jump()
    {
        var force = Mathf.Min(jumpForce, effectiveJumpForce);
        body.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        jumping = true;
        effectiveJumpForce = 0;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        jumping = false;
    }
}
