using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainGame : MonoBehaviour
{
    public static MainGame instance;
    public TextMeshProUGUI TimerText;

    float CurrentTime;
    public string FinalTime;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(instance.gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("BestTime") == 0)
        {
            PlayerPrefs.SetFloat("BestTime", 100000f);
            PlayerPrefs.Save();
        }
        CurrentTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime += 1 * Time.deltaTime;
        

        var ts = TimeSpan.FromSeconds(CurrentTime);
        TimerText.text = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
        FinalTime = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);

       

       
    }

    public void SavedBestTime()
    {
        if (PlayerPrefs.GetFloat("BestTime") >= CurrentTime)
        {
            PlayerPrefs.SetFloat("BestTime", CurrentTime);
            PlayerPrefs.Save();
        }
    }
     
}
