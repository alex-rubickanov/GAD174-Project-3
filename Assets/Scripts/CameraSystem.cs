using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    [SerializeField] GameObject[] CameraPositions;
    [SerializeField] GameObject[] buttons;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) // camera 0
        {
            CameraPositions[0].SetActive(true);
            CameraPositions[1].SetActive(false);
            CameraPositions[2].SetActive(false);
            CameraPositions[3].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow)) // camera 2
        {
            CameraPositions[0].SetActive(false);
            CameraPositions[1].SetActive(false);
            CameraPositions[2].SetActive(true);
            CameraPositions[3].SetActive(false);
            buttons[1].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) // camera 1
        {
            CameraPositions[0].SetActive(false);
            CameraPositions[1].SetActive(true);
            CameraPositions[2].SetActive(false);
            CameraPositions[3].SetActive(false);
            buttons[0].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) //camera 3
        {
            CameraPositions[0].SetActive(false);
            CameraPositions[1].SetActive(false);
            CameraPositions[2].SetActive(false);
            CameraPositions[3].SetActive(true);
        }
    }
}
