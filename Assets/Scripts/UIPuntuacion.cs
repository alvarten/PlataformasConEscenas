using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIPuntuacion : MonoBehaviour
{
    private static UIPuntuacion instance;
    public TextMeshProUGUI textoInventario; // Referencia al objeto de texto donde se mostrar� la informaci�n
    void Awake()
    {
        //Para pintar inicialmente las puntuaciones
        ActualizarInventario();

        //Para que el controlador de puntuaci�n no desaparezca al cambiar de escena
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Mantener el gestor en todas las escenas
        }
        else
        {
            Destroy(gameObject); // Evita duplicados
        }
    }
    // M�todo para actualizar el UI con las estad�sticas del inventario
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
