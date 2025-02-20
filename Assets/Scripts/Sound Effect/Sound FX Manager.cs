using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager:MonoBehaviour
{
    public static SoundFXManager instance;
    [SerializeField] private AudioSource soundFXObject;
   //  private int soundFXIndex=0;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void PlaySoundFXClip (AudioClip[] audioclip, Transform spawnTransform,float volume,int soundFXIndex)
    {
        AudioSource audioSource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);
        audioSource.clip = audioclip[soundFXIndex];
        audioSource.volume = volume;
    //    audioSource.loop = false;
        audioSource.Play();
        float clipLength =audioSource.clip.length;


    }
}
