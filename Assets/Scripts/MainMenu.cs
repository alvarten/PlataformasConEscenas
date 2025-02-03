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
        SceneManager.LoadScene("GameScene1");
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
