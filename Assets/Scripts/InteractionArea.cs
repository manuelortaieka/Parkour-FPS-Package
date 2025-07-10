using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject UIInteractionMessage;
    public bool canInteract;
    public InteractionObjects mercaderia;
    public ScoreManager scoreManager;
    public int puntos;

    void Start()
    {
        UIInteractionMessage.SetActive(false);
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canInteract)
            {
                Destroy(mercaderia.gameObject);
                scoreManager.AddScore(puntos);
                EndInteraction();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Debug.Log(other.gameObject.name);
        mercaderia = other.GetComponent<InteractionObjects>();
        if (mercaderia)
        {
            UIInteractionMessage.SetActive(true);
            canInteract = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        EndInteraction();
    }

    void EndInteraction()
    {
        UIInteractionMessage.SetActive(false);
        mercaderia = null;
        canInteract = false;
    }
}