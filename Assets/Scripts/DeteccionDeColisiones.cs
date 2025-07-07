using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    public ScoreManager scoreManager;
    public MercaderiaScript mercaderiaScript;

    void Start()
    {
        scoreManager =  FindObjectOfType<ScoreManager>();
        mercaderiaScript = GetComponent<MercaderiaScript>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
            scoreManager.AddScore(mercaderiaScript.scorePoints);
        }        
    }
}