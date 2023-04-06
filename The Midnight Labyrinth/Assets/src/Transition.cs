using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Transition : MonoBehaviour
{
    private GameObject passScreen;
    private GameObject failScreen;
    private GameObject gameEnd;
    [SerializeField] GameObject[] buttons=new GameObject[4];
    public AudioSource buttonSound;
    public static bool Alive ;
    public static string level;
    public static int lvlindex;
    // Start is called before the first frame update
    void Start()
    {
        passScreen = GameObject.Find("gameCanvas");
        failScreen = GameObject.Find("gameOverCanvas");
        gameEnd = GameObject.Find("gameFinishCanvas");
        if (Alive==false)
        {
            passScreen.GetComponent<Canvas>().enabled = false;
            gameEnd.GetComponent<Canvas>().enabled = false;
            failScreen.GetComponent<Canvas>().enabled = true;
        }
        else
        {
            if(lvlindex==6)
            {
                gameEnd.GetComponent<Canvas>().enabled = true;
            }
            else
            {
                passScreen.GetComponent<Canvas>().enabled = true;
                failScreen.GetComponent<Canvas>().enabled = false;
                gameEnd.GetComponent<Canvas>().enabled = false;
                if (Timer.lvltime < 180f)
                {
                    buttons[0].SetActive(true);
                    buttons[1].SetActive(true);
                    buttons[2].SetActive(true);
                    buttons[3].SetActive(true);

                }
                else if(Timer.lvltime <300f)
                {
                    buttons[0].SetActive(true);
                    buttons[1].SetActive(true);
                    buttons[2].SetActive(true);
                    buttons[3].SetActive(false);
                }
                else if (Timer.lvltime <720f)
                {
                    buttons[0].SetActive(true);
                    buttons[1].SetActive(true);
                    buttons[2].SetActive(false);
                    buttons[3].SetActive(false);
                }
                else
                {
                    buttons[0].SetActive (true);
                    buttons[1].SetActive(true);
                    buttons[2].SetActive(false);
                    buttons[3].SetActive(false);
                }
            }
            
        }
        
    }
    public void nextLevelButton()
    {
        if (lvlindex<5)
        {
            buttonSound.Play();
            lvlindex++;
            level="Level "+lvlindex.ToString();
            SceneManager.LoadScene(level);
        }
        /*else 
        {
            buttonSound.Play();
            SceneManager.LoadScene("Main Menu");
        }*/
    }

    public void retryLevelBT()
    {
        buttonSound.Play();
        SceneManager.LoadScene(level);
    }
   public void MainmenuBT()
    {
        buttonSound.Play();
        SceneManager.LoadScene("Main Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
