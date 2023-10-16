using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class MainMenuManager : MonoBehaviour
{
    public TextMeshProUGUI BestTimeText;
    public GameObject BestTimePanel;


    private void Start()
    {

        if (PlayerPrefs.GetString("FirstTimeOnGame") == "")
        {
            if (PlayerPrefs.GetFloat("BackgroundMusicVolume") == 0)
            {
                PlayerPrefs.SetFloat("BackgroundMusicVolume", 1);
                PlayerPrefs.Save();
            }

            if (PlayerPrefs.GetFloat("FXMusicVolume") == 0)
            {
                PlayerPrefs.SetFloat("FXMusicVolume", 1);
                PlayerPrefs.Save();
            }

            PlayerPrefs.SetString("FirstTimeOnGame", "Done");
            PlayerPrefs.Save();
        }

        if (PlayerPrefs.GetFloat("BestTime") == 0)
        {
            PlayerPrefs.SetFloat("BestTime", 100000f);
            PlayerPrefs.Save();
        }
        if(PlayerPrefs.GetFloat("BestTime") == 100000f)
        {
            BestTimePanel.SetActive(false);
        }
        Debug.Log("BestTime: " + PlayerPrefs.GetFloat("BestTime").ToString());

        var ts = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("BestTime"));
        BestTimeText.text = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
        //BestTimeText.text = PlayerPrefs.get
        PlayerPrefs.SetString("PlayerSelected", "");
        PlayerPrefs.Save();
    }
    public void SelectLevel_OnClick(string _LevelSelect)
    {
        PlayerPrefs.SetString("PlayerSelected", _LevelSelect);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainGame");

    }

}
