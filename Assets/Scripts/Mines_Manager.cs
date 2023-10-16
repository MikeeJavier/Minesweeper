using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Mines_Manager : MonoBehaviour
{
   // public static Mines_Manager instance;
    public GameObject BombImage_Button;
   // public GameObject FlagImage_Button;
    public int CountTheSidesBomb;

    

    public bool SafeButtonToOpen;
    bool GameEnded;

    int CountTheOpenedMines;
    bool hasOpened;
    bool hasEnabled;
    public SpriteRenderer PutFlag;
    public SpriteRenderer UnPutFlag;
    public SpriteRenderer GotoDefaultOneImage;

    public AudioSource ClickShovelSoundButton;
    public AudioSource ClickBombSoundButton;

 

    // Start is called before the first frame update
    void Start()
    {
        
        SafeButtonToOpen = false;
        GameEnded = false;
        hasEnabled = false;
        hasOpened = false;
        CountTheOpenedMines = 0;
        Time.timeScale = 1;
    }
    void Counter()
    {
        if (!hasEnabled)
        {
            if (hasOpened)
            {
                Game_Manager.instance.LevelWonSafeMines += 1;
                hasEnabled = true;
            }
           
        }
    }

    void GoBackToDefaultColor()
    {
        this.gameObject.GetComponent<Image>().sprite = GotoDefaultOneImage.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        Counter();
        if (SafeButtonToOpen)
        { 
                hasOpened = true;
           
            this.GetComponent<Image>().color = new Color32(186, 150, 132, 255);
            switch (CountTheSidesBomb)
            {
                case 0:
                    this.GetComponentInChildren<TextMeshProUGUI>().text = "";
                    this.gameObject.tag = "SafeZero";
                    this.gameObject.GetComponent<Button>().interactable = false;
                    GoBackToDefaultColor();
                    // make show the neighboring numbers except the bomb

                    break;
                case 1:
                    this.GetComponentInChildren<TextMeshProUGUI>().text = "1";
                    this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(53, 82, 219, 255);
                    this.gameObject.GetComponent<Button>().interactable = false;
                    GoBackToDefaultColor();
                    break;
                case 2:
                    this.GetComponentInChildren<TextMeshProUGUI>().text = "2";
                    this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(62, 197, 29, 255);
                    this.gameObject.GetComponent<Button>().interactable = false;
                    GoBackToDefaultColor();
                    break;
                case 3:
                    this.GetComponentInChildren<TextMeshProUGUI>().text = "3";
                    this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(205, 71, 72, 255);
                    this.gameObject.GetComponent<Button>().interactable = false;
                    GoBackToDefaultColor();
                    break;
                case 4:
                    this.GetComponentInChildren<TextMeshProUGUI>().text = "4";
                    this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(205, 71, 72, 255);
                    this.gameObject.GetComponent<Button>().interactable = false;
                    GoBackToDefaultColor();
                    break;
                case 5:
                    this.GetComponentInChildren<TextMeshProUGUI>().text = "5";
                    this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(205, 71, 72, 255);
                    this.gameObject.GetComponent<Button>().interactable = false;
                    GoBackToDefaultColor();
                    break;
                case 6:
                    this.GetComponentInChildren<TextMeshProUGUI>().text = "6";
                    this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(205, 71, 72, 255);
                    this.gameObject.GetComponent<Button>().interactable = false;
                    GoBackToDefaultColor();
                    break;
                case 7:
                    this.GetComponentInChildren<TextMeshProUGUI>().text = "7";
                    this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(205, 71, 72, 255);
                    this.gameObject.GetComponent<Button>().interactable = false;
                    GoBackToDefaultColor();
                    break;
                case 8:
                    this.GetComponentInChildren<TextMeshProUGUI>().text = "8";
                    this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(205, 71, 72, 255);
                    this.gameObject.GetComponent<Button>().interactable = false;
                    GoBackToDefaultColor();
                    break;
                case 9:
                    this.GetComponentInChildren<TextMeshProUGUI>().text = "9";
                    this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(205, 71, 72, 255);
                    this.gameObject.GetComponent<Button>().interactable = false;
                    GoBackToDefaultColor();
                    break;
            }

            //SafeButtonToOpen = false;
        }

        if(this.gameObject.tag == "SafeZero")
        {
            hasOpened = true;
        }

       if(this.gameObject.tag == "Safe" && CountTheSidesBomb == 0)
        {
           // this.GetComponent<Image>().color = new Color32(62, 197, 29, 255);
        }


        if (GameEnded)
        {
            GoBackToDefaultColor();
            this.gameObject.GetComponent<Button>().interactable = false;
            this.gameObject.GetComponent<Button>().enabled = false;
            Game_Manager.instance.GameOverPanel.SetActive(true);
            Game_Manager.instance.GameOverTimerText.text = MainGame.instance.FinalTime;
            Time.timeScale = 0;

        }
        
    }

    public void WonGame()
    { 
            this.gameObject.GetComponent<Button>().interactable = false;
            this.gameObject.GetComponent<Button>().enabled = false;
           
   
    }
    

    public void OnceClicked_MinesButton()
    {
        
        if (!Game_Manager.instance.OnPuttingFlag && !Game_Manager.instance.OnUnPuttingFlag)
        {
            if (this.gameObject.tag == "Safe")
            {
                ClickShovelSoundButton.Play();
                // Game_Manager.instance.LevelWonSafeMines += 1;
                this.GetComponent<Image>().color = new Color32(186, 150, 132, 255);
                switch (CountTheSidesBomb)
                {
                    case 0:
                        this.GetComponentInChildren<TextMeshProUGUI>().text = "";
                        this.gameObject.tag = "SafeZero";
                        this.gameObject.GetComponent<Button>().interactable = false;
                        GoBackToDefaultColor();
                        // make show the neighboring numbers except the bomb

                        break;
                    case 1:
                        this.GetComponentInChildren<TextMeshProUGUI>().text = "1";
                        this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(53, 82, 219, 255);
                        this.gameObject.GetComponent<Button>().interactable = false;
                        GoBackToDefaultColor();
                        hasOpened = true;
                        break;
                    case 2:
                        this.GetComponentInChildren<TextMeshProUGUI>().text = "2";
                        this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(62, 197, 29, 255);
                        this.gameObject.GetComponent<Button>().interactable = false;
                        GoBackToDefaultColor();
                        hasOpened = true;
                        break;
                    case 3:
                        this.GetComponentInChildren<TextMeshProUGUI>().text = "3";
                        this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(205, 71, 72, 255);
                        this.gameObject.GetComponent<Button>().interactable = false;
                        GoBackToDefaultColor();
                        hasOpened = true;
                        break;
                    case 4:
                        this.GetComponentInChildren<TextMeshProUGUI>().text = "4";
                        this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(205, 71, 72, 255);
                        this.gameObject.GetComponent<Button>().interactable = false;
                        GoBackToDefaultColor();
                        hasOpened = true;
                        break;
                    case 5:
                        this.GetComponentInChildren<TextMeshProUGUI>().text = "5";
                        this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(205, 71, 72, 255);
                        this.gameObject.GetComponent<Button>().interactable = false;
                        GoBackToDefaultColor();
                        hasOpened = true;
                        break;
                    case 6:
                        this.GetComponentInChildren<TextMeshProUGUI>().text = "6";
                        this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(205, 71, 72, 255);
                        this.gameObject.GetComponent<Button>().interactable = false;
                        GoBackToDefaultColor();
                        hasOpened = true;
                        break;
                    case 7:
                        this.GetComponentInChildren<TextMeshProUGUI>().text = "7";
                        this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(205, 71, 72, 255);
                        this.gameObject.GetComponent<Button>().interactable = false;
                        GoBackToDefaultColor();
                        hasOpened = true;
                        break;
                    case 8:
                        this.GetComponentInChildren<TextMeshProUGUI>().text = "8";
                        this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(205, 71, 72, 255);
                        this.gameObject.GetComponent<Button>().interactable = false;
                        GoBackToDefaultColor();
                        hasOpened = true;
                        break;
                    case 9:
                        this.GetComponentInChildren<TextMeshProUGUI>().text = "9";
                        this.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(205, 71, 72, 255);
                        this.gameObject.GetComponent<Button>().interactable = false;
                        GoBackToDefaultColor();
                        hasOpened = true;
                        break;
                }

                Debug.Log("Safe");
            }

            else if (this.gameObject.tag == "Bomb")
            {
                ClickBombSoundButton.Play();
                this.GetComponent<Image>().color = new Color32(186, 150, 132, 255);
                BombImage_Button.SetActive(true);
                GameEnded = true;
                Debug.Log("You lose");
            }
        } 
        if(Game_Manager.instance.OnPuttingFlag && !Game_Manager.instance.OnUnPuttingFlag)
        {   
                ClickShovelSoundButton.Play();
                //FlagImage_Button.SetActive(true);
                this.gameObject.GetComponent<Image>().sprite = PutFlag.sprite;
          
        } 
        if(Game_Manager.instance.OnUnPuttingFlag && !Game_Manager.instance.OnPuttingFlag)
        {   
                ClickShovelSoundButton.Play();
                //FlagImage_Button.SetActive(true);
                this.gameObject.GetComponent<Image>().sprite = UnPutFlag.sprite;
          
        }
        if(Game_Manager.instance.OnUnPuttingFlag && Game_Manager.instance.OnPuttingFlag)
        {   
                ClickShovelSoundButton.Play();
                //FlagImage_Button.SetActive(true);
                this.gameObject.GetComponent<Image>().sprite = UnPutFlag.sprite;
          
        }
        
       
         
    }

    IEnumerator GameOverPanelDelay()
    {
        yield return new WaitForSeconds(1f);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bomb")
        {
            CountTheSidesBomb += 1;
        } 
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "SafeZero" && this.gameObject.tag != "Bomb")
        {
            SafeButtonToOpen = true;
            //make the other safe to open
        }
    }
}
