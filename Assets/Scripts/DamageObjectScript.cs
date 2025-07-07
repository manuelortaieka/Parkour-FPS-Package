using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageObjectScript : MonoBehaviour
{
    public HealthManager healthManager;
    public int damagePoints;


    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            healthManager.TakeDamage(damagePoints);
            Destroy(gameObject);
        }
    }
}