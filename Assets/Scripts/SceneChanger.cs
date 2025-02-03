using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneToLoad; // Nombre de la escena a la que queremos ir
    public Transform spawnPoint; // Posicion del player

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Si el jugador entra en el área de transición
        {
            SpawnManager.SetSpawnPoint(spawnPoint.position); //Guardar la posicion del player
            SceneManager.LoadScene(sceneToLoad); // Cargar la nueva escena
        }
    }
}
