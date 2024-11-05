using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_folow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public int min;
    private Vector3 nulls;


    void LateUpdate ()
    {
        nulls = target.position
        if ( target.position > new Vector3(nulls.x,15,nulls.z))
        {
            target.y = 15;
        }
        transform.position = target.position + offset;
    }
}
