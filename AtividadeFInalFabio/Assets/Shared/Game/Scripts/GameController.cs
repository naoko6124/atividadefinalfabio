using System;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        public void LoseLife()
        {
            life--;
            if (life <= 0)
                SceneManager.LoadScene("GameOver");
        }

        public void AddPoint(int p)
        {
            points += p;
            if (points > 5)
                SceneManager.LoadScene("YouWin");
        }
    }
}
