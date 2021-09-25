using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Jumper _jumper;
    private bool _isGrounded;
    private void Awake()
    {
        _jumper = GetComponent<Jumper>();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded == true)
        {
            _isGrounded = false;
            _jumper.Jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.TryGetComponent(out Ground ground))
        {
            _isGrounded = true;
        }
    }
}
