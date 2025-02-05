using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject optionsPanel, menuPanel, controlsPanel;
    public void PlayGame()
    {
        //Si ya tiene valor se va al valor, en caso contrario se va al GameScene1
        //
        //PlayerPrefs.GetString("NextScene", sceneName);
        //SceneManager.LoadScene("GameScene1");

        // Verificar si existe un valor guardado en "NextScene"
        if (PlayerPrefs.HasKey("NextScene"))
        {
            // Si hay un valor guardado, cargar la escena guardada
            string nextScene = PlayerPrefs.GetString("NextScene");
            Debug.Log("Cargando escena guardada: " + nextScene);
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            // Si no hay un valor guardado, realiza una acción alternativa (ejemplo: cargar una escena predeterminada)
            Debug.Log("No se encontró ninguna escena guardada. Cargando escena predeterminada...");
            SceneManager.LoadScene("GameScene1");
        }
    }

    // Método para salir del juego
    public void QuitGame()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit(); // Cierra el juego (no funciona en el editor de Unity)
    }
    public void OpenOptions()
    {
        optionsPanel.SetActive(true); // Muestra el menú de opciones y oculta el menu princicipal
        menuPanel.SetActive(false);
    }

    public void CloseOptions()
    {
        optionsPanel.SetActive(false); // Oculta el menú de opciones y muestra el menu princicipal
        menuPanel.SetActive(true);
    }
    //Lo mismo pero con el menu controles
    public void OpenControls()
    {
        controlsPanel.SetActive(true);
        optionsPanel.SetActive(false);
    }

    public void CloseControls()
    {
        controlsPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }
}
