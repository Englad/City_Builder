using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] AudioSource audio;
    [SerializeField] GameObject toolbar;

    float musicVolume;

    public void Slider_Changed(float newValue) {
        musicVolume = newValue;
        audio.volume = musicVolume;
    }

    public void CloseGame() {
        Application.Quit();
    }
}
