using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private Movement _movement;

    private void Awake()
    {
        _movement = GetComponent<Movement>();
    }
    private void Update()
    {
        _movement.Move(Vector2.left);
    }
}
