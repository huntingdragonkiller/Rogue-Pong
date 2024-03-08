using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddleRight : Paddle
{
    // from tutorial
    public Rigidbody2D _ball;

    // from tutorial
    private void FixedUpdate()
    {
        if (this._ball.velocity.x > 0.0f)
        {
            if (this._ball.position.y > this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
            else if (this._ball.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            if (this.transform.position.y > 0.0f)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
            else if (this.transform.position.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }

    }
}
