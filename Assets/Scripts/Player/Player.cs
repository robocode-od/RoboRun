using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Jumper _jumper;
    private bool _isGrounded;
    private Wallet _wallet;
    private HealthHandler _health;

    private void Awake()
    {
        _jumper = GetComponent<Jumper>();
        _wallet = GetComponent<Wallet>();
        _health = GetComponent<HealthHandler>();
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Coin coin))
        {
            coin.PickUp();
            _wallet.AddCoin();
        }
        if (collision.TryGetComponent(out Obstacle obstacle))
        {
            _health.ApplyDamage(obstacle.GetDamage());
        }
    }
}
