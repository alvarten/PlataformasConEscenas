using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {        
        // En caso de ser el player
        if (other.CompareTag("Player"))
        {
            Coleccionable coleccionable = GetComponent<Coleccionable>();
            if (coleccionable != null)
            {
                coleccionable.Recolectar(); // Ejecuta el metodo de recolección
            }
        }
    }
}

