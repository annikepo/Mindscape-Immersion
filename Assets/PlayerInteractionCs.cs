
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
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
