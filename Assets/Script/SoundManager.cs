using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    private const float startVolume = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("SoundVolume"))
        {
            PlayerPrefs.SetFloat("SoundVolume", startVolume);
            LoadVolume();
        }
        else
        {
            LoadVolume();
        }
    }

   public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        SaveVolume();
    }

    private void LoadVolume()
    {
       volumeSlider.value = PlayerPrefs.GetFloat("SoundVolume", volumeSlider.value);
    }
    private void SaveVolume()
    {
        PlayerPrefs.SetFloat("SoundVolume",volumeSlider.value);
    }
}
