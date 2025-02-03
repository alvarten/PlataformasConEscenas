using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider volumeSlider; // Referencia al slider

    void Start()
    {
        // Cargar el volumen guardado
        if (PlayerPrefs.HasKey("GameVolume"))
        {
            float savedVolume = PlayerPrefs.GetFloat("GameVolume");
            AudioListener.volume = savedVolume;
            volumeSlider.value = savedVolume;
        }
        else
        {
            AudioListener.volume = 1f; // Volumen máximo por defecto
            volumeSlider.value = 1f;
        }

        // Evento para detectar cambios en el slider
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume; // Cambia el volumen del juego
        PlayerPrefs.SetFloat("GameVolume", volume); // Guarda la configuración
    }
}
