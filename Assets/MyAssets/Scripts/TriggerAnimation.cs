using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip sfx;
    void OnMouseDown()
    {
        anim.SetTrigger("_playAnimation");
        {
                if (audioSource == null);
                    audioSource = GetComponent<AudioSource>();
                    audioSource.PlayOneShot(sfx);
        }
    
    }
}
