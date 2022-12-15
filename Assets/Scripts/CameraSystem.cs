using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    [SerializeField] GameObject[] CameraPositions;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CameraPositions[0].SetActive(true);
            CameraPositions[1].SetActive(false);
            CameraPositions[2].SetActive(false);
            CameraPositions[3].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CameraPositions[0].SetActive(false);
            CameraPositions[1].SetActive(false);
            CameraPositions[2].SetActive(true);
            CameraPositions[3].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CameraPositions[0].SetActive(false);
            CameraPositions[1].SetActive(true);
            CameraPositions[2].SetActive(false);
            CameraPositions[3].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CameraPositions[0].SetActive(false);
            CameraPositions[1].SetActive(false);
            CameraPositions[2].SetActive(false);
            CameraPositions[3].SetActive(true);
        }
    }
}
