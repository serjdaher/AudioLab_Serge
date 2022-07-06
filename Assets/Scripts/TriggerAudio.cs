using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudio : MonoBehaviour
{

    public GameObject speaker;

    public AudioClip triggeredAudio;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = speaker.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(triggeredAudio, 2.0f);
        }
        
    }
}
