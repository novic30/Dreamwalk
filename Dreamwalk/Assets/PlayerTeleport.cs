using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{

    public Vector3 startPosition;

    void Start()
    {

        if (startPosition == Vector3.zero)
        {
            startPosition = transform.position;
        }
    }

    void OnTriggerEnter(Collider other)
    {
     
        if (other.CompareTag("Spike")) 
        {
            TeleportToStart();
        }
    }

    void TeleportToStart()
    {
     
        transform.position = startPosition;
    }
}
