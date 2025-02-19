
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Transform playerHand; // Reference to the camera rig's hand transform
    public float grabSpeed = 5f; // Speed at which the flower will move to the hand

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Flower"))
        {
            Flower flower = other.gameObject.GetComponent<Flower>();
            if (flower != null)
            {
                flower.Bloom();
            }
        }
    }
}
