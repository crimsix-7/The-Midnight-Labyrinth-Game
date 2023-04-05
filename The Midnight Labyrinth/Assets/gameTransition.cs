using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameTransition : MonoBehaviour
{

    public PlayerHealth playerHealth;
    public GameObject playerDead;
    public GameObject gameNext;
    public GameObject gameOver;
    public int level;
    //public bool playerAlive= PlayerHealth.

    public AudioSource buttonSound;
    // Start is called before the first frame update
    void Start()
    {
        playerDead = GameObject.Find("PlayerDeadCanvas");
        gameNext = GameObject.Find("gameCanvas");
        gameOver = GameObject.Find("gameOverCanvas");
       // if (player==false)
       // {
       //     playerDead.GetComponent<Canvas>().enabled = false;
       //     gameNext.GetComponent<Canvas>().enabled = false;
       //     gameOver.GetComponent<Canvas>().enabled = true;
       // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
