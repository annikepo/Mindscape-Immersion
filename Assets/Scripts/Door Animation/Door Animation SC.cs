using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrrigerDoorController:MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;
    [SerializeField] private string doorOpen ;
    [SerializeField] private string doorClose ;
    [SerializeField] private AudioClip[] doorSoundClip;


    private void OnTriggerEnter(Collider other)
    {
       // Debug.Log("panda move to the door");
        if (other.CompareTag("Panda"))
        {
       //     Debug.Log("panda Detected");
            if (openTrigger)
            {
                //         Debug.Log("panda door opening");
               
                myDoor.Play(doorOpen, 0, 0.0f);
                gameObject.SetActive(false);
                SoundFXManager.instance.PlaySoundFXClip(doorSoundClip, transform, 1f, 0);
            }
            else if (closeTrigger)
            {
       //        Debug.Log("panda door closing");
                myDoor.Play(doorClose, 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }


}
