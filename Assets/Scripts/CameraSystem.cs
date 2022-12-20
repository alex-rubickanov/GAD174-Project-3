using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    [SerializeField] GameObject[] CameraPositions;
    [SerializeField] GameObject[] buttons;
    [SerializeField] LightsaberAnimation lightsaberAnimation;

    public void Camera0() //from door
    {

            CameraPositions[0].SetActive(true);
            CameraPositions[1].SetActive(false);
            CameraPositions[2].SetActive(false);
            CameraPositions[3].SetActive(false);
            CameraPositions[4].SetActive(false);
            buttons[0].SetActive(false); //remote
            buttons[1].SetActive(false); //lightsaber
            lightsaberAnimation.animator.SetBool("State", false);
            lightsaberAnimation.lukeUI.SetActive(false);
    }
    public void Camera1() //trophies
    {

            CameraPositions[0].SetActive(false);
            CameraPositions[1].SetActive(false);
            CameraPositions[2].SetActive(true);
            CameraPositions[3].SetActive(false);
            CameraPositions[4].SetActive(false);
            buttons[1].SetActive(true); //lightsaber
            buttons[0].SetActive(false); //remote
    }

    public void Camera2() //couch
    {

            CameraPositions[0].SetActive(false);
            CameraPositions[1].SetActive(true);
            CameraPositions[2].SetActive(false);
            CameraPositions[3].SetActive(false);
            CameraPositions[4].SetActive(false);
            buttons[0].SetActive(true); //remote
            buttons[1].SetActive(false); //lightsaber
            lightsaberAnimation.animator.SetBool("State", false);
            lightsaberAnimation.lukeUI.SetActive(false);
    }
    public void Camera3() //tv
    {

            CameraPositions[0].SetActive(false);
            CameraPositions[1].SetActive(false);
            CameraPositions[2].SetActive(false);
            CameraPositions[3].SetActive(true);
            CameraPositions[4].SetActive(false);
            buttons[0].SetActive(false); //remote
            buttons[1].SetActive(false); //lightsaber
            lightsaberAnimation.animator.SetBool("State", false);
            lightsaberAnimation.lukeUI.SetActive(false);
      
    }
    public void ArcReactorCamera() //tv
    {

        CameraPositions[0].SetActive(false);
        CameraPositions[1].SetActive(false);
        CameraPositions[2].SetActive(false);
        CameraPositions[3].SetActive(false);
        CameraPositions[4].SetActive(true);
        buttons[0].SetActive(false); //remote
        buttons[1].SetActive(false); //lightsaber
        lightsaberAnimation.animator.SetBool("State", false);
        lightsaberAnimation.lukeUI.SetActive(false);

    }


}
