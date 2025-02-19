using UnityEngine;

public class FlowerGrabBloom : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private OVRGrabbable _grabbable;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _grabbable = GetComponent<OVRGrabbable>();

        // Ensure flower stays in Pandas hand initially
        _rigidbody.isKinematic = true;
        _rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the flower is grabbed by the player
        if (_grabbable.isGrabbed)
        {
            ReleaseFlower();
        }
    }

    private void ReleaseFlower()
    {
        // Enable physics so the flower can be grabbed
        _rigidbody.isKinematic = false;
        _rigidbody.useGravity = true;

        // Unparent from Pandas hand so it behaves like normal
        transform.parent = null;
    }
}
