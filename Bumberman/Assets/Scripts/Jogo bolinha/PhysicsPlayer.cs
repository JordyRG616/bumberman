using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsPlayer : MonoBehaviour
{
    [SerializeField] private Rigidbody2D body;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;


    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        var direction = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        body.AddForce(Vector2.right * direction);
    }

    private void Jump()
    {
        if(Input.GetButton("Jump"))
        {
            if(Input.GetButtonDown("W"))
            {
                
            }
            var direction = Vector2.up * jumpForce;
            body.AddForce(direction, ForceMode2D.Impulse);
        }
    }
}
