using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Text timerText;  
    private float timer = 0f;
    private bool isTimerRunning = false;  
    public GameObject mc;  
    public float startPositionX = -400f; 
    public float stopPositionX = -210f; 
    public float stopDistance = 1f;  

    
    void Start()
    {
       
        timer = 0f;
        isTimerRunning = false;
    }

   
    void Update()
    {
       
        if (!isTimerRunning && mc.transform.position.x >= startPositionX - stopDistance)
        {
            StartTimer();
        }

        
        if (isTimerRunning)
        {
            timer += Time.deltaTime;
            timerText.text = "Time: " + timer.ToString("F2");
        }

        
        if (isTimerRunning && mc.transform.position.x >= stopPositionX - stopDistance)
        {
            StopTimer();
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
