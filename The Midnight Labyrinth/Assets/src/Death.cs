using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    float timeelapsed;
    float timeTODelay = 1.4f;

    // Update is called once per frame
    void Update()
    {
        timeelapsed += Time.deltaTime;
        if (timeTODelay < timeelapsed )
        {
            SceneManager.LoadScene("Game");
        }
    }
}
