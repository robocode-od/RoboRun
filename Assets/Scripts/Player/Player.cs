using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Wallet _wallet;
    private HealthHandler _healthHandler;
    private Jumper _jumper;
    private Animator _animator;
    
    private bool _isGrounded;

    private void Awake()
    {
        _jumper = GetComponent<Jumper>();
        _wallet = GetComponent<Wallet>();
        _healthHandler = GetComponent<HealthHandler>();
        _animator = GetComponent<Animator>();

    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded == true)
        {
            _isGrounded = false;
            _jumper.Jump();
            _animator.SetTrigger("isJump");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.TryGetComponent(out Ground ground))
        {
            _isGrounded = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Coin coin))
        {
            _wallet.AddCoin();  
            coin.Destroy();
        }
        if (collision.TryGetComponent(out Obstacle enemy))
        {
            _healthHandler.ApplyDamage(enemy.GetDamage());
        }
    }
}
