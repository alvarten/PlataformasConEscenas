using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pauseMenuUI;  // El panel del men� de pausa
    private bool isPaused = false;  // Para saber si el juego est� pausado
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();  // Reanudar el juego
            }
            else
            {
                Pause();  // Pausar el juego
            }
        }
    }

    // Funci�n para pausar el juego
    public void Pause()
    {
        pauseMenuUI.SetActive(true); // Mostrar el men�
        Time.timeScale = 0f;         // Detener el tiempo en el juego
        isPaused = true;
    }
    // M�todo para reanudar el juego
    public void Resume()
    {
        pauseMenuUI.SetActive(false); // Ocultar el men�
        Time.timeScale = 1f;          // Restaurar el tiempo normal
        isPaused = false;
    }
    // M�todo para ir al men� principal
    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // Asegurar que el tiempo se reanuda antes de cambiar de escena
        SceneManager.LoadScene("MainMenu"); // Cambia la escena al men� principal (ajusta el nombre de la escena)
    }

    // M�todo para salir completamente del juego
    public void QuitGame()
    {
        Debug.Log("Saliendo del juego..."); // Esto solo se ver� en el editor de Unity
        Application.Quit(); // Cierra la aplicaci�n (en editor no funciona, pero en el build s�)
    }

}
