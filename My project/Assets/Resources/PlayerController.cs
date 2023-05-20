using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D rd;

    private Vector2 movement;

    // Update is called once per frame
    public void Move(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rd.MovePosition(rd.position+movement*moveSpeed*Time.fixedDeltaTime);
    }
}
