using System;
using Shared.Game.Scripts;
using UnityEngine;

namespace Shared.Enemy.Scripts
{
    public class EnemyMovement : MonoBehaviour
    {
        public float timer;
        public Vector2 speed;
        public int points;

        public GameObject effectExplode;
        public GameObject effectDamage;

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
            {
                if (effectExplode) Instantiate(effectExplode, transform.position, Quaternion.identity);
                GameController.Instance.points += points;
                Destroy(gameObject);
            }

            if (other.CompareTag("Player"))
            {
                if (effectDamage) Instantiate(effectDamage, other.transform.position, Quaternion.identity);
                GameController.Instance.LoseLife();
                Destroy(gameObject);
            }
        }
    }
}
