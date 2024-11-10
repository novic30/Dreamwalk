using UnityEngine;
using UnityEngine.UI; 

public class GameTimer : MonoBehaviour
{
    public Text timerText;  
    private float timer = 0f;
    private bool isTimerRunning = true; 
    public float targetXPosition = -255f;  
    public float stopDistance = 1f;  
    void Start()
    {
       
        Debug.Log("Timer target X position: " + targetXPosition);
    }

 
    void Update()
    {
        if (isTimerRunning)
        {
            timer += Time.deltaTime;
            timerText.text = "Time: " + timer.ToString("F2"); 

            
            if (Mathf.Abs(transform.position.x - targetXPosition) <= stopDistance)
            {
                StopTimer();
            }
        }
    }

    
    void StopTimer()
    {
        isTimerRunning = false;
        Debug.Log("Timer Stopped! Final Time: " + timer.ToString("F2"));
    }
}
