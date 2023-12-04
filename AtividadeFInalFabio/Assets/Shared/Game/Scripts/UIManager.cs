using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMP_Text txtPoints;
    public TMP_Text txtLife;


    private void Start()
    {
        txtPoints.text = "0";

        txtLife.text = "3";
    }

    public void ChangeScore(int points)
    {
        txtPoints.text = points.ToString();
    }

    public void ChangeVida(int life)
    {
        txtLife.text = life.ToString();
    }
}