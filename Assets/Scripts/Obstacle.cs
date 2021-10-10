using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Movement _movement;
    [SerializeField] private int _damage = 1;
    private void Start()
    {
        _movement = GetComponent<Movement>();
    }
    private void Update()
    {
        _movement.Move(Vector2.left);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    public int GetDamage()
    {
        return _damage;
    }
}
