using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reliquia : Coleccionable
{
    //public string Rareza; // Rareza de la reliquia (com�n, rara, legendaria)

    public override void Recolectar()
    {
        Debug.Log($"�Reliquia rara encontrada! Valor: {Valor}");
        ControladorInventario.AgregarAlInventario("Reliquias", Valor);
        FindObjectOfType<UIPuntuacion>().ActualizarInventario();
        Destroy(gameObject);
    }
}
