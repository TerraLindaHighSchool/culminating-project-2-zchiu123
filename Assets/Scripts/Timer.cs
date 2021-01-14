using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    private GameManager gameManager;
    Text countdownText;
    public float time = 20.0f;
    public bool timeOn;

    // Start is called before the first frame update
    public void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        countdownText = GetComponent<Text>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (timeOn == true)
        {
            time -= Time.deltaTime;
            string seconds = (time % 20).ToString("00");
            countdownText.text = seconds;
        }
        if (time <= 0)
        {
            timeOn = false;
            gameManager.GameOver();
        }

    }

    public void ClickPlay()
    {
        timeOn = true;
    }

    public void TimerOff()
    {
        timeOn = false;
    }

    
}
