using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private KeyCode key;
    [SerializeField] private KeyCode altKey;
    [SerializeField] private float chargeJump;
    [SerializeField] private float jumpForce;

    private Rigidbody2D body;
    private bool jumping;
    private float effectiveJumpForce;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(jumping) return;

        if(Input.GetKey(key) || Input.GetKey(altKey))
        {
            effectiveJumpForce += Time.deltaTime * chargeJump;
        }

        if(Input.GetKeyUp(key) || Input.GetKeyUp(altKey))
        {
            var force = Mathf.Min(effectiveJumpForce, jumpForce);
            body.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            effectiveJumpForce = 0;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        jumping = true;        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        jumping = false;        
    }
}
