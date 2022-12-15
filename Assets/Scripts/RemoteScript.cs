using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class RemoteScript : MonoBehaviour
{
    Animator animator;

    [SerializeField] VideoPlayer tvScreen;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PowerOn()
    {
        animator.SetTrigger("Power");

        if(tvScreen.enabled == false)
        {
            tvScreen.enabled = true;
        }
        else
        {
            tvScreen.enabled = false;
        }

    }

  
}
