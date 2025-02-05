using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIPuntuacion : MonoBehaviour
{
    public TextMeshProUGUI textoInventario; // Referencia al objeto de texto donde se mostrará la información
    void Awake()
    {
        ActualizarInventario();
    }
    // Método para actualizar el UI con las estadísticas del inventario
    public void ActualizarInventario()
    {
        int monedas = ControladorInventario.ObtenerCantidad("Monedas");
        int gemas = ControladorInventario.ObtenerCantidad("Gemas");
        int reliquias = ControladorInventario.ObtenerCantidad("Reliquias");
        int puntosTotales = monedas + gemas + reliquias; // Calcular los puntos

        // Generar el texto
        string texto = $"Monedas: {monedas}\nGemas: {gemas}\nReliquias: {reliquias}\nPuntos Totales: {puntosTotales}";

        // Mostrar el texto
        textoInventario.text = texto;
    }
}
