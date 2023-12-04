using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

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

        public UIManager uiManager;

        public void LoseLife()
        {
            life--;
            uiManager.ChangeVida(life);
            if (life <= 0)
                SceneManager.LoadScene("GameOver");
        }

        public void AddPoint(int p)
        {
            points += p;
            uiManager.ChangeScore(points);
            if (points > 5)
                SceneManager.LoadScene("YouWin");
        }
    }
}
