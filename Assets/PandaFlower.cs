using UnityEngine;

public class PandaAnimation : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Starting walking animation");
            animator.SetTrigger("Walk");
        }
    }
}
