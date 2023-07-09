using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSFXManager : MonoBehaviour
{
    public List<AudioClip> audioClips = new List<AudioClip>();
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayCardSelectSFX()
    {
        audioSource.clip = audioClips[0];
        audioSource.Play();
    }

    public void PlayCardDiscardSFX()
    {
        audioSource.clip = audioClips[1];
        audioSource.Play();
    }
}
