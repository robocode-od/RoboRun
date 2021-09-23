using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    public void Move(Vector2 direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
