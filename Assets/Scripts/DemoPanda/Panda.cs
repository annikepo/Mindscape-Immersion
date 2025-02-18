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

    public void HoldFlowers()
    {
        ClearPrevStates();
        _animator.SetTrigger("holdFlowers");
    }

    public void TakeDownArm()
    {
        ClearPrevStates();
        _animator.SetTrigger("takeDownArm");
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

        if (_animator == null)
        {
            Debug.LogError("Animator component missing on Panda! Make sure Panda has an Animator.");
            return;
        }

        _animeParams = _animator.parameters; // Assign the animation parameters only if _animator is valid

        if (_animeParams.Length == 0 )
        {
            Debug.LogWarning("No animation parameters found in Animator, check Animatior Controller");
        }
    }


    private void ClearPrevStates()
    {
        if (_animator == null || _animeParams == null)
        {
            Debug.LogError("Animator or animation parameters not initialized in Panda.");
            return;
        }

        foreach (var param in _animeParams)
        {
            if (param.type == AnimatorControllerParameterType.Bool)
            {
                _animator.SetBool(param.name, false);
            }
        }
    }
}
