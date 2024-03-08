using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    // from tutorial
    private Vector2 _direction;

    private UpgradeObjects upgradeObjects;

    // from tutorial
    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }

    // from tutorial
    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * this.speed);
        }

    }

    // added
    public void AddUpgrade(UpgradeObjects upgradeToAssign, int ID)
    {
        upgradeObjects = upgradeToAssign;
        if (ID == 1)
        {
            Debug.Log("Speed Up");
            AddSpeed(0.25f);
        }
        if (ID == 2)
        {
            Debug.Log("Scale Up");
            AddScale(0.1f);
        }
        if (ID == 3)
        {
            Debug.Log("Drag down");
            DecreaseDrag(0.1f);
        }
    }

    public void AddSpeed(float newSpeed)
    {
        this.speed += newSpeed;
    }

    public void AddScale(float newScale)
    {
        Vector2 _scaleUp = new Vector2(_size.localScale.x, this.paddleSize += newScale);
        _size.localScale = _scaleUp;
    }

    public void DecreaseDrag(float newDrag)
    {
        _rigidbody.drag -= newDrag;
    }
}
