using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameTimer : MonoBehaviour
{
    public TMP_Text timerText;  
    private float timer = 0f;
    private bool isTimerRunning = false;  
    private bool startTime = false;  
    public GameObject mc;  
    public float startPositionX = -640f; 
    public float stopPositionX = -210f; 

    
    void Start()
    {
       
        timer = 0f;
        isTimerRunning = false;
    }

   
    void Update()
    {
       
        if (!isTimerRunning && !startTime && mc.transform.position.x >= startPositionX )
        {
            StartTimer();
            startTime = true;
        }

        
        if (isTimerRunning)
        {
            timer += Time.deltaTime;
            timerText.text = "Time: " + timer.ToString("F2");
        }

        
        if (isTimerRunning && mc.transform.position.x >=  stopPositionX)
        {
            StopTimer();
        }
        
        if(isTimerRunning && mc.transform.position.x <= startPositionX )
        {
            timer = 0f;
        }
    }

    
    void StartTimer()
    {
        isTimerRunning = true;
        Debug.Log("Timer Started");
    }

    
    void StopTimer()
    {
        isTimerRunning = false;
        Debug.Log("Timer Stopped! Final Time: " + timer.ToString("F2"));
    }
}
