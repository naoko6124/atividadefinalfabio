using System;
using UnityEngine;

namespace Shared.Player.Scripts
{
    public class PlayerShoot : MonoBehaviour
    {
        public GameObject bullet;
        public float timerToShoot;
        private float _timer;

        private void Start()
        {
            _timer = 0f;
        }

        private void Update()
        {
            _timer -= Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space) && _timer < 0f)
            {
                _timer = timerToShoot;
                Instantiate(bullet, transform);
            }
        }
    }
}
