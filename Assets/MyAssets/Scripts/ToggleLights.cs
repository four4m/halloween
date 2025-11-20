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
        bool anyLightTurnedOn = false;

        foreach (Light light in getLights)
        {
            light.enabled = !light.enabled;

            if (light.enabled)
                anyLightTurnedOn = true;
        }

        if (anyLightTurnedOn)
        {
            if (lightOn.Length > 0)
            {
                int i = Random.Range(0, lightOn.Length);
                if (lightOn[i] != null)
                {
                    audioSource.clip = lightOn[i];
                    audioSource.loop = true;
                    audioSource.Play();
                }
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
}
