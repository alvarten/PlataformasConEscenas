using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SpawnManager : MonoBehaviour
{
    public Transform defaultSpawnPoint; // Punto de inicio por defecto
    private static Vector2 playerSpawnPosition = Vector2.zero; // Posici�n del jugador entre escenas

    void Awake()
    {
        // Si no hay una posici�n guardada, usa la posici�n por defecto
        if (playerSpawnPosition == Vector2.zero)
        {
            playerSpawnPosition = defaultSpawnPoint.position;
        }

        // Encontrar al jugador y moverlo a la posici�n guardada
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            player.transform.position = playerSpawnPosition;
        }
    }

    // M�todo para establecer la posici�n del jugador antes de cambiar de escena
    public static void SetSpawnPoint(Vector2 newPosition)
    {
        playerSpawnPosition = newPosition;
    }
}
