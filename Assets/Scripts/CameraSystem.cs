using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    [SerializeField] GameObject[] CameraPositions;

    private void Update()
    {
        if (Input.GetKeyDown("[6]"))
        {
            CameraPositions[0].SetActive(true);
            CameraPositions[1].SetActive(false);
            CameraPositions[2].SetActive(false);
            CameraPositions[3].SetActive(false);
        }

        if (Input.GetKeyDown("[4]"))
        {
            CameraPositions[0].SetActive(false);
            CameraPositions[1].SetActive(false);
            CameraPositions[2].SetActive(true);
            CameraPositions[3].SetActive(false);
        }

        if (Input.GetKeyDown("[5]"))
        {
            CameraPositions[0].SetActive(false);
            CameraPositions[1].SetActive(true);
            CameraPositions[2].SetActive(false);
            CameraPositions[3].SetActive(false);
        }

        if (Input.GetKeyDown("[8]"))
        {
            CameraPositions[0].SetActive(false);
            CameraPositions[1].SetActive(false);
            CameraPositions[2].SetActive(false);
            CameraPositions[3].SetActive(true);
        }
    }
}
