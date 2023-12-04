using System;
using UnityEngine;

namespace Shared.Enemy.Scripts
{
    public class EnemyMovement : MonoBehaviour
    {
        public float timer;
        public Vector2 speed;

        private Rigidbody2D _rigidbody2D;

        private void OnEnable()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();

            _rigidbody2D.velocity = speed;
        }

        void Update()
        {
            timer -= Time.deltaTime;
            if (timer < 0)
                Destroy(gameObject);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Bullet"))
                Destroy(gameObject);
        }
    }
}
