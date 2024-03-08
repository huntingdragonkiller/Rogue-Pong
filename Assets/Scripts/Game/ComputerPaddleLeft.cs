using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComputerPaddleLeft : Paddle
{
    // from tutorial
    public Rigidbody2D _ball;

    // from tutorial
    private void FixedUpdate()
    {
        if (this._ball.velocity.x < 0.0f)
        {
            if(this._ball.position.y > this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            } else if (this._ball.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            if(this.transform.position.y > 0.0f)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            } else if (this.transform.position.y < 0.0f) {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }

    private void OnLevelWasLoaded(int level)
    {
        if(level == 3)
        {
            this.speed = 7.0f;
            Vector2 _scale = new Vector2(_size.localScale.x, 2.25f);
            _size.localScale = _scale;
        } else
        {
            this.speed = 10.0f;
            Vector2 _scale = new Vector2(_size.localScale.x, 1.5f);
            _size.localScale = _scale;
        }
        if(level == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
