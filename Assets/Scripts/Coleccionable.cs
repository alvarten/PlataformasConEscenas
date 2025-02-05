using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    public string Nombre; // Nombre del coleccionable
    public int Valor;     // Puntos que suma
    protected int ElProtegido; //Este valor demomento no tiene funcionalidad

    // Función virtual que sirve de base para la recolección de coleccionables
    public virtual void Recolectar()
    {
        Debug.Log($"Has recolectado un {Nombre} que vale {Valor} puntos.");
    }
}
