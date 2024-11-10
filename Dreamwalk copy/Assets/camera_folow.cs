using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_folow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    private Vector3 finalPos;


    void LateUpdate ()
    {
        if ( target.position.y + offset.y >= 14.5f)
        {
            finalPos = new Vector3(offset.x + target.position.x,14.5f, offset.z + target.position.z);
        }
        else
        {
            finalPos = offset + target.position;
        }
        transform.position = finalPos;
    }
}
