using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip clip;
    [SerializeField]
    private AudioClip clip1;

    public void PlayAudioButton() {
        audioSource.PlayOneShot(clip);
    }

    public void PlayAudioOnHover() {
        audioSource.PlayOneShot(clip1);
    }
}
