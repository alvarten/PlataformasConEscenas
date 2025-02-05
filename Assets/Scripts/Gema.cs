using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gema : Coleccionable
{
    //public string Color; // Propiedad espec�fica para gemas

    public override void Recolectar()
    {
        Debug.Log($"�Gema recolectada! Valor: {Valor}");
        ControladorInventario.AgregarAlInventario("Gemas", Valor);
        FindObjectOfType<UIPuntuacion>().ActualizarInventario();
        Destroy(gameObject);
    }
}
