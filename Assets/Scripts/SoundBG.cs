using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBG : MonoBehaviour
{

    private void Update()
    {
        this.gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("BackgroundMusicVolume");
    }

}
