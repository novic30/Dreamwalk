using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed = 1;
    public int jump = 1;
    float Up;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float LeftRight = Input.GetAxis("Horizontal"); 
        float Up = Input.GetAxis("Vertical");
            
        Vector3 movement = new Vector3(LeftRight * speed * Time.deltaTime, Up * jump * Time.deltaTime, 0);
        transform.position += movement;

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
    }
}
