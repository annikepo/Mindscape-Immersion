
using UnityEngine;

public class Flower : MonoBehaviour
{
    private bool isBlooming = false;

    void Update()
    {
        if (isBlooming)
        {
            // Add blooming effect logic here (e.g., increase size, change color)
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(2, 2, 2), Time.deltaTime);
        }
    }

    public void Bloom()
    {
        isBlooming = true;
    }
}
