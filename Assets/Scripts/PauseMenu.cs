using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{    
    public GameObject pauseMenuUI;  // El panel del menú de pausa
    private bool isPaused = false;  // Para saber si el juego está pausado
    private static PauseMenu instance;
    void Awake()
    {
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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
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

    // Función para pausar el juego
    public void Pause()
    {
        pauseMenuUI.SetActive(true); // Mostrar el menú
        Time.timeScale = 0f;         // Detener el tiempo en el juego
        isPaused = true;
    }
    // Método para reanudar el juego
    public void Resume()
    {
        pauseMenuUI.SetActive(false); // Ocultar el menú
        Time.timeScale = 1f;          // Restaurar el tiempo normal
        isPaused = false;
    }
    // Método para ir al menú principal
    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // Asegurar que el tiempo se reanuda antes de cambiar de escena
        SceneManager.LoadScene("MainMenu"); // Cambia la escena al menú principal
    }

    // Método para salir completamente del juego
    public void QuitGame()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit(); // Cierra la aplicación
    }

}
