using System.Collections.Generic;
using UnityEngine;

public class ToggleLights : MonoBehaviour
{
    [SerializeField] Light[] getLights;
    [SerializeField] AudioClip[] lightOn;
    [SerializeField] AudioSource audioSource;

    void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        foreach (Light light in getLights)
        {
            if (light == null) continue;

            light.enabled = !light.enabled;

            if (light.enabled)
            {
                if (audioSource == null || lightOn == null || lightOn.Length == 0) continue;
                int randomIndex = Random.Range(0, lightOn.Length);
                AudioClip clip = lightOn[randomIndex];
                if (clip == null) continue;
                audioSource.PlayOneShot(clip);
            }
        }
    }
}
