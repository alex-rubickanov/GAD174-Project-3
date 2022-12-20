using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Video;

public class RemoteScript : MonoBehaviour
{
    [SerializeField] GameObject camera1;
    [SerializeField] GameObject[] tvVideos;
    [SerializeField] GameObject tvBlckScreen;
    [SerializeField] GameObject tvPlayer;
    [SerializeField] AudioSource tvAudio;
    [SerializeField] GameObject muteIcon;

    int videoNumber = 0;

    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();    
    }
    private void Update()
    {
        ZoomRemote();
        videoHandler();
        print(videoNumber);
    }

    private void ZoomRemote()
    {
        if (camera1.active == true)
        {
            animator.SetBool("ZoomRemote", true);
        }
        else
        {
            animator.SetBool("ZoomRemote", false);
        }
    }

    public void PowerOn()
    {
        videoNumber = 0;
        animator.SetTrigger("Power");

        if (tvBlckScreen.active == true && tvPlayer.active == false)
        {
            tvBlckScreen.SetActive(false);
            tvPlayer.SetActive(true);
        }
        else
        {
            tvBlckScreen.SetActive(true);
            tvPlayer.SetActive(false);
        }

    }

    public void NextButton()
    {
        animator.SetTrigger("next");

        if (tvPlayer.active == true)
        {
            videoNumber++;
        }
        if (videoNumber >= 3 || videoNumber == -1)
        {
            videoNumber = 0;
        }
    }

    public void PreviousButton()

    {
        animator.SetTrigger("prev");

        if (tvPlayer.active == true)
        {
            videoNumber--;
        }
        if (videoNumber <= -1 || videoNumber == 3)
        {
            videoNumber = 2;
        }
    }


    public void videoHandler()
    {
        if (videoNumber == 0)
        {
            tvVideos[0].active = true;
            tvVideos[1].active = false;
            tvVideos[2].active = false;
            tvVideos[3].active = false;
            tvVideos[4].active = false;

        }
        else if (videoNumber == 1)
        {
            tvVideos[0].active = false;
            tvVideos[1].active = true;
            tvVideos[2].active = false;
            tvVideos[3].active = false;
            tvVideos[4].active = false;

        }
        else if (videoNumber == 2)
        {
            tvVideos[0].active = false;
            tvVideos[1].active = false;
            tvVideos[2].active = true;
            tvVideos[3].active = false;
            tvVideos[4].active = false;

        }
    }

    public void MuteTV()
    {
        animator.SetTrigger("mute");
        if (muteIcon.active  == false && tvPlayer.active == true)
        {
            tvAudio.mute = true;
            muteIcon.SetActive(true);
        }
        else
        {
            tvAudio.mute = false;
            muteIcon.SetActive(false);
        }
    }

    public void PlayNintendo()
    {
        videoNumber = 4;
        if (tvPlayer.active == true)
        {
            tvVideos[0].active = false;
            tvVideos[1].active = false;
            tvVideos[2].active = false;
            tvVideos[3].active = true;
            tvVideos[4].active = false;
        }
    }

    public void PlayPS5()
    {
        videoNumber = -1;
        if (tvPlayer.active == true)
        {
            tvVideos[0].active = false;
            tvVideos[1].active = false;
            tvVideos[2].active = false;
            tvVideos[3].active = false;
            tvVideos[4].active = true;
        }
    }
}
