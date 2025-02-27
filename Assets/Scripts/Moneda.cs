using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Moneda : Coleccionable
{
    //Constructor
    public Moneda(int valor, string nombre)
    {
        Valor = valor;
        Nombre = nombre;
    }
    public override void Recolectar()
    {
        //Debug.Log("�Moneda recolectada! " +Valor+ " puntos.");
        ControladorInventario.AgregarAlInventario("Monedas", Valor);
        FindObjectOfType<UIPuntuacion>().ActualizarInventario();
        Destroy(gameObject); // Elimina la moneda del juego
    }
}
