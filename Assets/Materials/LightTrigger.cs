using UnityEngine;
using System.Collections;

public class LightTrigger : MonoBehaviour
{
    public AudioClip triggerSound;
    AudioSource audioSource;

    void Start()
    {
		    // Add a AudioSource component to the current GameObject,
		    // feed it the clip that is provided to this script,
		    // and set it to be a spatialized 3D sound
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = triggerSound;
        audioSource.spatialBlend = 1.0f;
    }

    void OnTriggerEnter(Collider other)
    {
		    // If the 'thing' that enters the trigger has the 'Player' tag
		    // play the clip that is loaded into the audio source
        if (other.CompareTag("Player"))
        {
            audioSource.Play();
        }
    }
}