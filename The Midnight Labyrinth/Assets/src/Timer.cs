using System;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public static float lvltime;
    // Component used to display the timer
    [Header("Component")]
    public TextMeshProUGUI timerText;

    // The current time of the timer
    [Header("Timer Settings")]
    public float currentTime;

    // Flag indicating whether the timer counts down or up
    public bool countDown;

    // Flag indicating whether the timer has a limit
    [Header("Limit Settings")]
    public bool hasLimit;

    // The limit of the timer
    public float timerLimit;

    // Flag indicating whether to format the timer text
    [Header("Format Time")]
    public bool useFormattedTime = false;

    void Start()
    {
        // Initialization code here
    }   

    void Update()
    {
        // Update the current time based on the count direction
        if (Transition.Alive==true)
        {
            currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
            lvltime = currentTime;
        }
        

        // Check if the timer has reached its limit
        if(hasLimit && ((countDown && currentTime <= timerLimit  || (!countDown && currentTime >= timerLimit))))
        {
            // If the limit is reached, set the current time to the limit and stop the timer
            currentTime = timerLimit;
            SetTimertext();
            timerText.color = Color.red;
            enabled = false;
        }
        // Update the timer text display
        SetTimertext();
    }

    private void SetTimertext()
    {
        if (useFormattedTime)
        {
            // Format the current time as hours:minutes:seconds
            TimeSpan timeSpan = TimeSpan.FromSeconds(currentTime);
            string formattedTime = string.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            timerText.text = formattedTime;
        }
        else
        {
            // Display the current time as is
            timerText.text = currentTime.ToString();
        }
    }
}
