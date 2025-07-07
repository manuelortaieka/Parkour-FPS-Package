using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public int maxHealthPoints;
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        healthPoints = maxHealthPoints;
    }

    public void TakeDamage(int damagePoints)
    {
        if (healthPoints <= damagePoints)
        {
            SceneManager.LoadScene("FPS Parkour");
        }
        Debug.Log("Damage taken");
        healthPoints-= damagePoints;
        uiManager.UpdateHealth(healthPoints);
    }
 
}