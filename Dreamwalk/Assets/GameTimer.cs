using UnityEngine;
using UnityEngine.UI; 

public class GameTimer : MonoBehaviour
{
    public Text timerText;  
    private float timer = 0f;
    private bool isTimerRunning = true; 
    public GameObject mc;
    public float stopDistance = 1f;  
    void Start()
    {   
    }

 
    void Update()
    {
        if (isTimerRunning)
        {
            timer += Time.deltaTime;
            timerText.text = "Time: " + timer.ToString("F2"); 
            
            
        }
            
            if (mc.transform.position.x >= -210f)
            {
                StopTimer();
            }
    }
    

    
    void StopTimer()
    {
        isTimerRunning = false;
        Debug.Log("Timer Stopped! Final Time: " + timer.ToString("F2"));
    }
}
