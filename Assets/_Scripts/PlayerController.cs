using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public FixedJoystick joystick;
    private Rigidbody2D _rigidbody2D;
    private Vector2 _move;

    public float moveSpeed = 5.0f;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _move.x = joystick.Horizontal;
        _move.y = joystick.Vertical;

        if (joystick.Horizontal > 0)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        else if (joystick.Horizontal < 0)
        {
            transform.eulerAngles = new Vector3(0, 180f, 0f);
        }
    }

    private void FixedUpdate()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + _move * moveSpeed * Time.fixedDeltaTime);
    }
}
