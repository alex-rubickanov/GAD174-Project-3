using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcSound : MonoBehaviour
{
    [SerializeField] AudioClip arcSound;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayArcSound()
    {
        audioSource.PlayOneShot(arcSound);
    }
}
