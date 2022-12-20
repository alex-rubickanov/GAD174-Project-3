using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    [SerializeField] GameObject[] CameraPositions;
    [SerializeField] GameObject[] buttons;

    public void Camera0()
    {

            CameraPositions[0].SetActive(true);
            CameraPositions[1].SetActive(false);
            CameraPositions[2].SetActive(false);
            CameraPositions[3].SetActive(false);
    }
    public void Camera1()
    {

            CameraPositions[0].SetActive(false);
            CameraPositions[1].SetActive(false);
            CameraPositions[2].SetActive(true);
            CameraPositions[3].SetActive(false);
            buttons[1].SetActive(true);
    }

    public void Camera2()
    {

            CameraPositions[0].SetActive(false);
            CameraPositions[1].SetActive(true);
            CameraPositions[2].SetActive(false);
            CameraPositions[3].SetActive(false);
            buttons[0].SetActive(true);
        }
    public void Camera3()
    {

            CameraPositions[0].SetActive(false);
            CameraPositions[1].SetActive(false);
            CameraPositions[2].SetActive(false);
            CameraPositions[3].SetActive(true);
     }
}
