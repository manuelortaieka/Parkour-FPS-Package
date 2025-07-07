using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtHealthPoints;

    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }
    public void UpdateScore(int score)
    {
        txtScore.text = score.ToString();
    }

    public void UpdateHealth(int health)
    {
        txtHealthPoints.text = health.ToString();
    }


}