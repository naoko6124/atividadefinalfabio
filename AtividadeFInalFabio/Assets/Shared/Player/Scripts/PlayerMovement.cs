using System;
using UnityEngine;

namespace Shared.Player.Scripts
{
    public class PlayerMovement : MonoBehaviour
    {
        public float moveSpeed;
        
        private float _verticalInput = 0f;

        private Rigidbody2D _rigidbody2D;

        private void OnEnable()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        void Start()
        {
        
        }

        void Update()
        {
            _verticalInput = Input.GetAxis("Vertical");

            _rigidbody2D.velocity = Vector2.up * (moveSpeed * _verticalInput);
        }
    }
}
