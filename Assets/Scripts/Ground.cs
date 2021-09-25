using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private Movement _movement;
    private Vector2 _startPosition;
    private Vector2 _endPosition;
    [SerializeField] private float _moveDistance = 3f;

    private void Start()
    {
        _movement = GetComponent<Movement>();
        _startPosition = transform.position;
        _endPosition = _startPosition;
        _endPosition.x -= _moveDistance;
    }
    private void Update()
    {
        _movement.Move(Vector2.left);
        if(transform.position.x <= _endPosition.x)
        {
            transform.position = _startPosition;
        }
    }
}
