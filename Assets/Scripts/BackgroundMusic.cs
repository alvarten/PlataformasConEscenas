using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    
    private static BackgroundMusic instance;
    private AudioSource audioSource;    
    public AudioClip menuMusic;
    public AudioClip gameMusic;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Mantiene la música entre escenas
            audioSource = GetComponent<AudioSource>();
            SceneManager.sceneLoaded += OnSceneLoaded; // Detecta cambios de escena
        }
        else
        {
            Destroy(gameObject); // Evita duplicados
        }
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        ChangeMusic(SceneManager.GetActiveScene().name); // Carga la música de la escena actual al iniciar
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        ChangeMusic(scene.name); // Cambia la música cuando la escena cambia
    }

    void ChangeMusic(string sceneName)
    {
        AudioClip newMusic = null;

        if (sceneName == "MainMenu")
            newMusic = menuMusic;
        else if (sceneName == "GameScene1" || sceneName == "GameScene2")
            newMusic = gameMusic;       

        if (newMusic != null && audioSource.clip != newMusic)
        {
            audioSource.clip = newMusic;
            audioSource.Play();
        }
    }
}
