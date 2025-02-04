using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class SceneLoader : MonoBehaviour
{
    private static SceneLoader instance;

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

    // Método público para cambiar de escena con pantalla de carga
    public void LoadScene(string sceneName)
    {
        // Si ya estamos en la pantalla de carga, no hagamos nada
        if (SceneManager.GetActiveScene().name == "LoadingScene")
            return;

        PlayerPrefs.SetString("NextScene", sceneName); // Guardar el nombre de la escena
        StartCoroutine(LoadSceneAsync());
    }

    IEnumerator LoadSceneAsync()
    {
        SceneManager.LoadScene("LoadingScene"); // Cargar la pantalla de carga
        yield return null;
    }
}
