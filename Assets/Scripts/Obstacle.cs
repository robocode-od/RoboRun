using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Movement _movement;
    private void Start()
    {
        _movement = GetComponent<Movement>();
    }
    private void Update()
    {
        _movement.Move(Vector2.left);
    }
}
