using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // added
    [SerializeField] private AudioClip _hitSound;
    public float paddleSize = 1.5f;
    protected Transform _size;

    // from tutorial
    public float speed = 10;
    protected Rigidbody2D _rigidbody;

    // from tutorial
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        
        // added
        _size = GetComponent<Transform>();
    }

    // from tutorial
    public void ResetPosition()
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
        _rigidbody.velocity = Vector2.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            AudioManager.Instance.PlayMusic(_hitSound);
        }
    }

    public void OnLevelWasLoaded(int level)
    {
        if (level == 0)
        {
            Destroy(gameObject);
        }
    }
}
