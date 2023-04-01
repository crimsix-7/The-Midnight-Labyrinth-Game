
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 3;
    public AudioSource audioPlayer;
    private float delayTime = 2.0f;
    private float timeElapsed;

    PlayerHandler playerHandler;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        playerHandler = GetComponent<PlayerHandler>();
    }

    // Update is called once per frame
    void changeScene()
    {
        SceneManager.LoadScene("Scene0");
        Destroy(gameObject);
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            playerHandler.TriggerDeathAnimation();
            audioPlayer.Play();
            Invoke("changeScene", 1.0f);
            


        }


    }
    
}
