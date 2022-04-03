using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timerText;
    public static bool timeStarted = false;
    public static bool inside = false;
    public static bool finished = false;
    private float startTime;
    private void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if(finished)
        {
            return;
        }
        if(timeStarted)
        {
            startTime = Time.time;
            timeStarted = false;
            inside = true;
        }
        if(inside)
        {
            float t = Time.time - startTime;
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f1");
            timerText.text = minutes + ":" + seconds;
        }
        
        
        
        
    }
    public void Entered()
    {
        timeStarted = true;
    }
    public void Exited()
    {
        inside = false;
        finished = true;
        timerText.color = Color.red;
    }
    
}
