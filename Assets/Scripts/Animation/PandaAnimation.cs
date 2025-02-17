using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class PandaAnimation : MonoBehaviour
{
    [SerializeField] private Panda _panda;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if ( _panda == null )
        {
            Debug.LogError("Panda script not found in scene");
            return;
        }

        // Ensure Panda's Start() method is executed
        _panda.SendMessage("Start");

        StartCoroutine(PandaRoutine());
    }

    private IEnumerator PandaRoutine()
    {
        // Panda waits outside of door;
        _panda.Capoeira();
        yield return new WaitForSeconds(10f);

        // Panda opens the door
        _panda.OpenDoor();
        yield return new WaitForSeconds(1f); // This is the wait time before panda opens the door

        // Panda walks in after opening door
        _panda.Walk();
        yield return new WaitForSeconds(3f); 

       // Panda greets you
        _panda.Greet();
        yield return new WaitForSeconds(5f);

        _panda.HandOverFlowers();
        yield return new WaitForSeconds(3f);
    }
}
