using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed = 1;
    public int jump = 1;
    float LeftRight;
    float Up;
    public bool onground = false;
    public Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LeftRight = Input.GetAxis("Horizontal"); 
        Up = Input.GetAxis("Vertical");
        if (LeftRight <0)
            {
                transform.rotation = Quaternion.Euler(0,0,20);
            }
            if (LeftRight ==0)
            {
                transform.rotation = Quaternion.Euler(0,0,0);
            }
            if (LeftRight >0)
            {
                transform.rotation = Quaternion.Euler(0,0,-20);
            }
        if (onground)
        {
            rb2d.velocity = new Vector2 (LeftRight * speed, Up * jump);
        }
        else
        {
            rb2d.velocity += new Vector2 (((LeftRight * speed)/2)*Time.deltaTime,0);
        }
    }
    private void OnCollisionStay2D(Collision2D other) 
    {
        onground = true;
    }
    private void OnCollisionExit2D(Collision2D other) 
    {
        onground = false;
    }
}
