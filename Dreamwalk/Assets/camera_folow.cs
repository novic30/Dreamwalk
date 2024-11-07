using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_folow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    private Vector3 offset2;


    void LateUpdate ()
    {
        if ( target.position.y + offset.y > 14.5f)
        {
            offset2 = new Vector3(offset.x,14.5f, offset.z);
        }
        else
        {
            offset2 = offset;
        }
        transform.position = target.position + offset2;
    }
}
