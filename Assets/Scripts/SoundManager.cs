using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Slider FXMusicVolume_Slider;
    public Slider BackgroundMusicVolume_Slider;

    private void Update()
    {
        BackgroundMusicVolume_Slider.value = PlayerPrefs.GetFloat("BackgroundMusicVolume");
        FXMusicVolume_Slider.value = PlayerPrefs.GetFloat("FXMusicVolume");
    }

    public void GetBackgroundMusicVol(float _BGVolume)
    {
        PlayerPrefs.SetFloat("BackgroundMusicVolume", _BGVolume);
        PlayerPrefs.Save();
        
    }
    public void GetFXMusicVol(float _FXVolume)
    {
        PlayerPrefs.SetFloat("FXMusicVolume", _FXVolume);
        PlayerPrefs.Save();
         
    }
}
