using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Tranparent_wording : MonoBehaviour
{
    public GameObject mc;

    [Header("Fade Out Script")]
    public TMP_Text text1;
    public TMP_Text text2;
    public TMP_Text arrow1;
    public TMP_Text arrow2;
    public TMP_Text arrow3;
    public TMP_Text arrow4;
    public TMP_Text arrow5;
    [Tooltip("Will start the fade out after value (in seconds)")]
    public float timeToStartFading1 = 0.3f;
    public float timeToStartFading2 = 0f;
    public float FadeArrow1 = 2f;
    public float FadeArrow2 = 4f;
    public float FadeArrow3 = 6f;
    public float FadeArrow4 = 8f;
    public float FadeArrow5 = 10f;
    [Tooltip("Higher values = faster Fade Out")]
    public float fadeSpeed = 0.3f;

    private bool Apressed = false;
    private bool Dpressed = false;
    private bool Wpressed = false;
    private bool Entpressed = false;
    private bool fadeStarted1 = false;
    private bool fadeStarted2 = false;
    private bool fadeArrow1 = false;
    private bool fadeArrow2 = false;
    private bool fadeArrow3 = false;
    private bool fadeArrow4 = false;
    private bool fadeArrow5 = false;
        private bool positionSet = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.E)) {
            Entpressed = true;
            Debug.Log("Enter key pressed!");

        }

        if (Entpressed && !positionSet){
            Vector3 newPosition = mc.transform.position;
            newPosition.x = -640f;
            positionSet = true;
            mc.transform.position = newPosition;
        }


        if (Input.GetKey(KeyCode.A)) {
            Apressed = true;
        }
        if (Input.GetKey(KeyCode.D)) {
            Dpressed = true;
        }

        if (Input.GetKey(KeyCode.W)) {
            Wpressed = true;
        }

        if (Apressed && Dpressed && !fadeStarted1) {
            timeToStartFading1 -= Time.deltaTime;
            

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

            FadeArrow1 -= Time.deltaTime;
            FadeArrow2 -= Time.deltaTime;
            FadeArrow3 -= Time.deltaTime;
            FadeArrow4 -= Time.deltaTime;
            FadeArrow5 -= Time.deltaTime;

        if (FadeArrow1 <= 0f) {
            fadeArrow1 = true;
        }
        if (FadeArrow2 <= 0f) {
            fadeArrow2 = true;
        }
        if (FadeArrow3 <= 0f) {
            fadeArrow3 = true;
        }
        if (FadeArrow4 <= 0f) {
            fadeArrow4 = true;
        }
        if (FadeArrow5 <= 0f) {
            fadeArrow5 = true;
        }

        if (fadeStarted1) {
            text1.color = new Color(text1.color.r, text1.color.g, text1.color.b, text1.color.a - (fadeSpeed * Time.deltaTime));
        }
        if (fadeStarted2) {
            text2.color = new Color(text2.color.r, text2.color.g, text2.color.b, text2.color.a - (fadeSpeed * Time.deltaTime));
        }
        if (fadeArrow1) {
            arrow1.color = new Color(arrow1.color.r, arrow1.color.g, arrow1.color.b, arrow1.color.a - (fadeSpeed * Time.deltaTime));
        }
        if (fadeArrow2) {
            arrow2.color = new Color(arrow2.color.r, arrow2.color.g, arrow2.color.b, arrow2.color.a - (fadeSpeed * Time.deltaTime));
        }
        if (fadeArrow3) {
            arrow3.color = new Color(arrow3.color.r, arrow3.color.g, arrow3.color.b, arrow3.color.a - (fadeSpeed * Time.deltaTime));
        }
        if (fadeArrow4) {
            arrow4.color = new Color(arrow4.color.r, arrow4.color.g, arrow4.color.b, arrow4.color.a - (fadeSpeed * Time.deltaTime));
        }
        if (fadeArrow5) {
            arrow5.color = new Color(arrow5.color.r, arrow5.color.g, arrow5.color.b, arrow5.color.a - (fadeSpeed * Time.deltaTime));
        }
    }
}
