using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Jumper _jumper;
    private void Awake()
    {
        _jumper = GetComponent<Jumper>();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _jumper.Jump();
        }
    }
}
