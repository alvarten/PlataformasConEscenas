using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPersist : MonoBehaviour
{
    private static MenuPersist instance;

    void Awake()
    {
        // Comprueba si ya existe una instancia de este objeto
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Evita que el objeto sea destruido
        }
        else
        {
            Destroy(gameObject); // Si ya existe, destruye este duplicado
        }
    }
}
