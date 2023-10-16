using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour
{

    private void Update()
    {
        this.gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("FXMusicVolume");
    }

}
