using System;
using UnityEngine;

namespace Shared.Player.Scripts
{
    public class PlayerShoot : MonoBehaviour
    {
        public GameObject bullet;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Instantiate(bullet, transform);
        }
    }
}
