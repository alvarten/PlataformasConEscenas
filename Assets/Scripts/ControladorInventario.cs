using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInventario : MonoBehaviour
{
    // Diccionario para guardar la cantidad recolectada de cada tipo
    private static Dictionary<string, int> inventario = new Dictionary<string, int>
    {
        { "Monedas", 0 },
        { "Gemas", 0 },
        { "Reliquias", 0 }
    };

    // Lista para guardar coleccionables recolectados
    private static List<Coleccionable> coleccionados = new List<Coleccionable>();

    // Función estática para agregar al inventario
    public static void AgregarAlInventario(string tipo, int cantidad)
    {
        if (inventario.ContainsKey(tipo))
        {
            inventario[tipo] += cantidad;
            Debug.Log($"Inventario actualizado: {tipo} ahora tiene {inventario[tipo]} unidades.");
        }
    }
    // Metodo para obtener cantidad de un tipo de coleccionable
    public static int ObtenerCantidad(string tipo)
    {
        if (inventario.ContainsKey(tipo))
        {
            return inventario[tipo];
        }
        return 0; 
    }
    
}
