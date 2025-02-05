using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gema : Coleccionable
{
    public string Color; // Propiedad específica para gemas
    //Constructor
    public Gema(int valor, string nombre, string color)
    {
        Valor = valor;
        Nombre = nombre;
        Color = color;
    }

    public override void Recolectar()
    {
        //Debug.Log("¡Gema recolectada! Valor: " +Valor);
        ControladorInventario.AgregarAlInventario("Gemas", Valor);
        FindObjectOfType<UIPuntuacion>().ActualizarInventario();
        Destroy(gameObject);
    }
}
