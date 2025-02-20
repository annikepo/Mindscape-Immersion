using Oculus.Interaction;
using UnityEngine;

public class FlowerGrabBloom : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Animator _animator;

    public void GetGrabbed()
    {
        ReleaseFlower();
        // we can comment in the line below if we don't want the flower to bloom when it's grabbed by player
        Bloom();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

        // Ensure flower stays in Pandas hand initially
        _rigidbody.isKinematic = true;
        _rigidbody.useGravity = false;
        
        _animator = GetComponent<Animator>();
    }

    private void ReleaseFlower()
    {
        // Enable physics so the flower can be grabbed
        _rigidbody.isKinematic = false;
        _rigidbody.useGravity = true;

        // Unparent from Pandas hand so it behaves like normal
        transform.parent = null;
    }

    private void Bloom()
    {
        _animator.SetBool("IsInVase", true);
    }
}
