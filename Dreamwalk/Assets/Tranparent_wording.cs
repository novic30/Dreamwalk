using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Tranparent_wording : MonoBehaviour
{
    [Header("Fade Out Script")]
    public TMP_Text text1;
    public TMP_Text text2;
    [Tooltip("Will start the fade out after value (in seconds)")]
    public float timeToStartFading1 = 2f;
    public float timeToStartFading2 = 2f;
    [Tooltip("Higher values = faster Fade Out")]
    public float fadeSpeed = 0.3f;

    private bool Apressed = false;
    private bool Dpressed = false;
    private bool Wpressed = false;
    private bool fadeStarted1 = false;
    private bool fadeStarted2 = false;
    public GameObject gameObject;
    

//-760
    void Start()
    {

    }
    void Update()
    {
        // Check if A and D keys have been pressed
        if (Input.GetKey(KeyCode.A)) {
            Apressed = true;
        }
        if (Input.GetKey(KeyCode.D)) {
            Dpressed = true;
        }

        if (Input.GetKey(KeyCode.W)) {
            Wpressed = true;
        }

        // Start countdown to fade only after both keys are pressed
        if (Apressed && Dpressed && !fadeStarted1) {
            timeToStartFading1 -= Time.deltaTime;

            // When countdown reaches zero, start fading
            if (timeToStartFading1 <= 0f) {
                fadeStarted1 = true;
            }
        }

        if (Wpressed && transform.position.x > -760 && !fadeStarted2) {
            timeToStartFading2 -= Time.deltaTime;

            if (timeToStartFading2 <= 0f) {
                fadeStarted2 = true;
            }
        }

        // Apply fade effect once fadeStarted is true
        if (fadeStarted1) {
            text1.color = new Color(text1.color.r, text1.color.g, text1.color.b, text1.color.a - (fadeSpeed * Time.deltaTime));
        }
        if (fadeStarted2) {
            text2.color = new Color(text2.color.r, text2.color.g, text2.color.b, text2.color.a - (fadeSpeed * Time.deltaTime));
        }
    }
}
