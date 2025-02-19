using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace MyGame.Animation
{
    public class PandaAnimation : MonoBehaviour
    {
        [SerializeField] private Panda _panda;
        [SerializeField] private Transform _targetPoistion;
        [SerializeField] private Transform _exitPosition;
        [SerializeField] private float _walkSpeed = 2f;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Awake()
        {
            if (_panda == null)
            {
                Debug.LogError("Panda script not found in scene");
                return;
            }

            if (_targetPoistion == null)
            {
                Debug.LogError("Target Position for Panda is not set");
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
            Debug.Log("Panda: Capoeira Dance");
            yield return new WaitForSeconds(10f);

            // Panda opens the door
            _panda.OpenDoor();
            Debug.Log("Panda: Open door");
            yield return new WaitForSeconds(10f); // This is the wait time before panda opens the door

            // Panda walks in after opening door
            _panda.Walk();
            Debug.Log("Panda: Walk");
            yield return StartCoroutine(MoveToPosition(_panda.transform, _targetPoistion.position, _walkSpeed));

            // Panda greets you
            _panda.Greet();
            Debug.Log("Panda: Greet");
            yield return new WaitForSeconds(5f);

            // Panda does the dance
            _panda.Capoeira();
            Debug.Log("Panda: Capoeira Dance");
            yield return new WaitForSeconds(10f);

            // Panda hands over flowers
            _panda.HandOverFlowers();
            Debug.Log("Panda: Hand Over Flowers");
            yield return new WaitForSeconds(3f);

            // Panda holds flower towards user
            _panda.HoldFlowers();
            Debug.Log("Panda: Holds flower to user");
            yield return new WaitForSeconds(10f);

            //Panda takes down empty arm
            _panda.TakeDownArm();
            Debug.Log("Panda: Takes down arm");
            yield return new WaitForSeconds(2f);

            // Panda turns around
            _panda.Turn();
            Debug.Log("Panda: Turns Around");
            yield return new WaitForSeconds(2f);

            // Panda walks out
            _panda.Walk();
            Debug.Log("Panda: Walk out");
            yield return StartCoroutine(MoveToPosition(_panda.transform, _exitPosition.position, _walkSpeed));
        }

        // Coroutine to move the Panda smoothly to target position
        private IEnumerator MoveToPosition(Transform panda, Vector3 target, float speed)
        {
            while (Vector3.Distance(panda.position, target) > 0.1f)
            {
                panda.position = Vector3.MoveTowards(panda.position, target, speed * Time.deltaTime);
                yield return null;
            }
        }
    }
}
