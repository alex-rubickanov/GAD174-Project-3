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
        if (camera1.activeSelf == true)
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

        if (tvBlckScreen.activeSelf == true && tvPlayer.activeSelf == false)
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

        if (tvPlayer.activeSelf == true)
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

        if (tvPlayer.activeSelf == true)
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
            tvVideos[0].SetActive(true);
            tvVideos[1].SetActive(false);
            tvVideos[2].SetActive(false); ;
            tvVideos[3].SetActive(false);
            tvVideos[4].SetActive(false);

        }
        else if (videoNumber == 1)
        {
            tvVideos[0].SetActive(false);
            tvVideos[1].SetActive(true);
            tvVideos[2].SetActive(false);
            tvVideos[3].SetActive(false);
            tvVideos[4].SetActive(false);

        }
        else if (videoNumber == 2)
        {
            tvVideos[0].SetActive(false);
            tvVideos[1].SetActive(false);
            tvVideos[2].SetActive(true); ;
            tvVideos[3].SetActive(false);
            tvVideos[4].SetActive(false);

        }
    }

    public void MuteTV()
    {
        animator.SetTrigger("mute");
        if (muteIcon.activeSelf  == false && tvPlayer.activeSelf == true)
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
        if (tvPlayer.activeSelf == true)
        {
            tvVideos[0].SetActive(false);
            tvVideos[1].SetActive(false);
            tvVideos[2].SetActive(false);
            tvVideos[3].SetActive(true);
            tvVideos[4].SetActive(false);
        }
    }

    public void PlayPS5()
    {
        videoNumber = -1;
        if (tvPlayer.activeSelf == true)
        {
            tvVideos[0].SetActive(false);
            tvVideos[1].SetActive(false);
            tvVideos[2].SetActive(false);
            tvVideos[3].SetActive(false);
            tvVideos[4].SetActive(true);
        }
    }
}
