using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Shared.Enemy.Scripts
{
    public class EnemySpawner : MonoBehaviour
    {
        public float timer;
        private float _timer;
        public float range;
        public GameObject enemy;

        private void Start()
        {
            _timer = timer;
        }

        private void Update()
        {
            _timer -= Time.deltaTime;

            if (_timer < 0)
            {
                _timer = timer;

                Vector3 pos = transform.position;
                
                float ypos = pos.y + Random.Range(-range, range);

                Instantiate(enemy, new Vector3(pos.x, ypos, pos.z), Quaternion.identity);
            }
        }
    }
}
