using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{    
    public float minLoadingTime = 2f;

    private void Start()
    {
        string sceneToLoad = PlayerPrefs.GetString("NextScene", "MainMenu"); // Recupera la escena guardada
        StartCoroutine(LoadSceneAsync(sceneToLoad));
    }

    IEnumerator LoadSceneAsync(string sceneName)
    {
        float startTime = Time.time;

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        operation.allowSceneActivation = false; // Evitar que la escena se active automáticamente

        

        // Asegurar un tiempo mínimo en la pantalla de carga
        float elapsedTime = Time.time - startTime;
        if (elapsedTime < minLoadingTime)
        {
            yield return new WaitForSeconds(minLoadingTime - elapsedTime);
        }

        operation.allowSceneActivation = true; // Ahora sí activamos la escena
    }
}
