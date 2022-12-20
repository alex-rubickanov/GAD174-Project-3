using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class RemoteScript : MonoBehaviour
{
    Animator animator;

    [SerializeField] VideoPlayer [] tvScreen;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PowerOn()
    {
        animator.SetTrigger("Power");
        tvScreen[1].enabled = false;
        tvScreen[2].enabled = false;
        if (tvScreen[0].enabled == false)
        {
            tvScreen[0].enabled = true;
        }
        else
        {
            tvScreen[0].enabled = false;
        }

    }
    public void PlayNintendo()
    {
        animator.SetTrigger("Power");
        tvScreen[0].enabled = false;
        tvScreen[2].enabled = false;
        if (tvScreen[1].enabled == false)
        {
            tvScreen[1].enabled = true;
        }
        else
        {
            tvScreen[1].enabled = false;
        }

    }
    public void PlayPlaystation()
    {
        animator.SetTrigger("Power");
        tvScreen[0].enabled = false;
        tvScreen[1].enabled = false;
        if (tvScreen[2].enabled == false)
        {
            tvScreen[2].enabled = true;
        }
        else
        {
            tvScreen[2].enabled = false;
        }

    }



}
