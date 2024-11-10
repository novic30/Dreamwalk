using UnityEngine;
using TMPro;
using UnityEngine.UI; 

public class GameTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float startTime;
    private bool isGameRunning = true;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (isGameRunning)
        {
            float elapsedTime = Time.time - startTime;
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    public void StopTimer()
    {
        isGameRunning = false;
        Debug.Log("Timer stopped at: " + timerText.text);
    }
}
