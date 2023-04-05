using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            Debug.Log("Hooray!!! You Won!");
            Transition.Alive = true;
            SceneManager.LoadScene("Game");
            Debug.Log("MainMenu");
        }
    }
}
