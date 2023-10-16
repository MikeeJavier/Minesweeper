using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    public static Game_Manager instance;
    public GameObject minesweeper_Button;
    public Transform Container;
    public GameObject ContainerImage;

    bool hasDoneInstantiating;
    public int CountInstantiated;
    public int[] RandomRealBomb;

    string LevelSelected;

    public GameObject GameOverPanel;
    public TextMeshProUGUI GameOverTimerText;

    public GameObject WonGamePanel;
    public TextMeshProUGUI WinGameTimerText;


    public int LevelWonSafeMines;

    public bool OnPuttingFlag;
    public bool OnUnPuttingFlag;
    public GameObject PutFlagBTN;
    public GameObject UnPutFlagBTN;



    private void Awake()
    {
        LevelWonSafeMines = 0;
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(instance.gameObject);
        }
    }

    void Start()
    {
        LevelWonSafeMines = 0;
        hasDoneInstantiating = false;
        OnPuttingFlag = false;
        OnUnPuttingFlag = false;

        #region Real Bomb Randomize

        RandomRealBomb = new int[32];
        // For level 8
        RandomRealBomb[0] = Random.Range(1, 4);
        RandomRealBomb[1] = Random.Range(5, 8);
        RandomRealBomb[2] = Random.Range(9, 12);
        RandomRealBomb[3] = Random.Range(13, 16);
        RandomRealBomb[4] = Random.Range(17, 20);
        RandomRealBomb[5] = Random.Range(21, 24);
        RandomRealBomb[6] = Random.Range(25, 28);
        RandomRealBomb[7] = Random.Range(29, 32);
        RandomRealBomb[8] = Random.Range(33, 36);
        RandomRealBomb[9] = Random.Range(37, 40);
        RandomRealBomb[10] = Random.Range(41, 44);
        RandomRealBomb[11] = Random.Range(45, 48);
        RandomRealBomb[12] = Random.Range(49, 52);
        RandomRealBomb[13] = Random.Range(53, 56);
        RandomRealBomb[14] = Random.Range(57, 60);
        RandomRealBomb[15] = Random.Range(61, 64);
        // end of level 8
        // For level 16x16
        RandomRealBomb[16] = Random.Range(65, 68);
        RandomRealBomb[17] = Random.Range(69, 72);
        RandomRealBomb[18] = Random.Range(73, 76);
        RandomRealBomb[19] = Random.Range(77, 80);
        RandomRealBomb[20] = Random.Range(81, 84);
        RandomRealBomb[21] = Random.Range(85, 88);
        RandomRealBomb[22] = Random.Range(89, 92);
        RandomRealBomb[23] = Random.Range(93, 96);
        RandomRealBomb[24] = Random.Range(97, 100);
        RandomRealBomb[25] = Random.Range(101, 104);
        RandomRealBomb[26] = Random.Range(105, 108);
        RandomRealBomb[27] = Random.Range(109, 112);
        RandomRealBomb[28] = Random.Range(113, 116);
        RandomRealBomb[29] = Random.Range(117, 120);
        RandomRealBomb[30] = Random.Range(121, 124);
        RandomRealBomb[31] = Random.Range(125, 128);
        // end
        #endregion

        LevelSelected = PlayerPrefs.GetString("PlayerSelected");

    }

   


    void Update()
    {
        if(LevelSelected == "Beginner")
        {
            Level8x8();
        }
        else if(LevelSelected == "Hard")
        {
            ContainerImage.GetComponent<RectTransform>().sizeDelta = new Vector2(1440, 800);  
            Level16x16();
        }

 
        if(LevelSelected == "Beginner")
        {
            if(LevelWonSafeMines == 48)
            {
                MainGame.instance.SavedBestTime();
                WonGamePanel.SetActive(true);
                WinGameTimerText.text = MainGame.instance.FinalTime;
                Time.timeScale = 0;
            }
        }
        else if(LevelSelected == "Hard")
        {
            if (LevelWonSafeMines == 96)
            {
                MainGame.instance.SavedBestTime();
                WonGamePanel.SetActive(true);
                WinGameTimerText.text = MainGame.instance.FinalTime;
                Time.timeScale = 0;
            }
        } 
       
    }

    void Level8x8()
    {

        if (CountInstantiated >= 64)
        {
            hasDoneInstantiating = true;
        }

        if (!hasDoneInstantiating)
        {
            for (int i = 1; i < 65; i++)
            {
                #region For The Bomb Instantiated
                if (i == RandomRealBomb[0])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[1])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[2])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[3])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[4])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[5])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[6])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[7])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[8])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[9])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[10])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[11])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[12])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[13])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[14])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[15])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Safe";
                }
                #endregion

                CountInstantiated = i;
            }

        }

    }


    void Level16x16()
    {

        if (CountInstantiated >= 128)
        {
            hasDoneInstantiating = true;
        }

        if (!hasDoneInstantiating)
        {
            for (int i = 1; i < 129; i++)
            {
                #region For The Bomb Instantiated
                if (i == RandomRealBomb[0])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[1])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[2])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[3])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[4])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[5])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[6])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[7])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[8])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[9])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[10])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[11])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[12])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[13])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[14])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[15])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[16])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[17])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[18])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[19])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[20])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[21])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[22])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[23])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[24])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[25])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[26])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[27])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[28])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[29])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[30])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else if (i == RandomRealBomb[31])
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Bomb";
                }
                else
                {
                    GameObject minesGO = Instantiate(minesweeper_Button, Container.transform);
                    minesGO.tag = "Safe";
                }
                #endregion

                CountInstantiated = i;
            }

        }

    }

   

    public void PlayAgainButton_OnClick()
    {
        
        SceneManager.LoadScene("MainGame");
        Time.timeScale = 1;
    }
    public void BackToMainMenuButton_OnClick()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void PutFlag_OnClickButton()
    {
        if(!OnPuttingFlag)
        {
            OnPuttingFlag = true;
            PutFlagBTN.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
        else if(OnPuttingFlag)
        {
            OnPuttingFlag = false;
            PutFlagBTN.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
    public void UnPutFlag_OnClickButton()
    {
        if(!OnUnPuttingFlag)
        {
            OnUnPuttingFlag = true;
            UnPutFlagBTN.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
        else if(OnUnPuttingFlag)
        {
            OnUnPuttingFlag = false;
            UnPutFlagBTN.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }


}
