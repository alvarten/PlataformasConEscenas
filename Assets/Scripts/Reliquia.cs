using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reliquia : Coleccionable
{
    public string Rareza; // Rareza de la reliquia (común, rara, legendaria)
    //Constructor
    public Reliquia(int valor, string nombre, string rareza)
    {
        Valor = valor;
        Nombre = nombre;
        Rareza = rareza;
    }

    public override void Recolectar()
    {
        //Debug.Log("¡Reliquia rara encontrada! Valor: " +Valor);
        ControladorInventario.AgregarAlInventario("Reliquias", Valor);
        FindObjectOfType<UIPuntuacion>().ActualizarInventario();
        Destroy(gameObject);
    }
}
