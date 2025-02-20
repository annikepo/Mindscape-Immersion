using UnityEngine;

public class GrabDebug : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hand detected: " + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Hand exited: " + other.name);
    }
}

