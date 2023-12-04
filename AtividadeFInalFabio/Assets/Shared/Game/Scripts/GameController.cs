using System;
using UnityEngine;

namespace Shared.Game.Scripts
{
    public class GameController : MonoBehaviour
    {
        public static GameController Instance;

        private void OnEnable()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }

        public int life;
        public int points;
    }
}
