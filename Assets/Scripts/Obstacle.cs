using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private int _damage;
    private Movement _movement;

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
