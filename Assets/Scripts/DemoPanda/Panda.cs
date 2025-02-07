using UnityEngine;

public class Panda : MonoBehaviour
{
    private Animator _animator;
    private AnimatorControllerParameter[] _animeParams;
    public void Walk()
    {
        ClearPrevStates();
        _animator.SetBool("walk", true);
    }

    public void OpenDoor()
    {
        ClearPrevStates();
        _animator.SetTrigger("openDoor");
    }
    
    public void Greet()
    {
        ClearPrevStates();
        _animator.SetTrigger("greet");
    }

    public void HandOverFlowers()
    {
        ClearPrevStates();
        _animator.SetTrigger("handOverFlowers");
    }

    public void SitDown()
    {
        ClearPrevStates();
        _animator.SetTrigger("sitDown");
    }

    public void StandUp()
    {
        ClearPrevStates();
        _animator.SetTrigger("standUp");
    }
    
    public void Capoeira()
    {
        ClearPrevStates();
        _animator.SetTrigger("capoeira");
    }
    
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _animeParams = _animator.parameters;
        
        // Debug.Log("Available Panda animation states: ");
        // foreach (var param in _animeParams)
        // {
        //     Debug.Log(param.name);
        // }
    }

    private void ClearPrevStates()
    {
        foreach (var param in _animeParams)
        {
            _animator.SetBool(param.name, false);
        }
    }
}
