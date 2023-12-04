using System;
using UnityEngine;

namespace Shared.Effects.Scripts
{
    public class Effect : MonoBehaviour
    {
        public float timer;

        private void Update()
        {
            timer -= Time.deltaTime;
            if (timer < 0f)
                Destroy(gameObject);
        }
    }
}
