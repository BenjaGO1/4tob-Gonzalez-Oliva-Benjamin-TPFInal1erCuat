using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform jugador;
    UnityEngine.AI.NavMeshAgent enemigo;
    private bool dentro = false;

    void Start()
    {
        enemigo = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        if (!dentro)
        {
            enemigo.destination = jugador.position;
        }
        if (dentro)
        {
            enemigo.destination = this.transform.position;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            dentro = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "jugador")
        {
            dentro = false;
        }
    }
}
