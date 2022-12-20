using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcReactor : MonoBehaviour
{
    [SerializeField] GameObject trophyCamera;
    [SerializeField] GameObject arcBtn;
    [SerializeField] GameObject arcReactorCam;

    //UI elements
    bool enable = false;
    [SerializeField] GameObject arcDesign1;
    [SerializeField] GameObject arcDesign2;
    [SerializeField] GameObject UIText;
    [SerializeField] Animator animator;

    //Sound
    [SerializeField] AudioClip arcSound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        //Enable Button when camera switch to cam2
        if(trophyCamera.activeSelf == true)
        {
            arcBtn.SetActive(true);
        }
        else
        {
            arcBtn.SetActive(false);
        }
        //Disabling UI if arc reactor cam isnt On
        if(arcReactorCam.activeSelf == false)
        {
            enable = false;
        }
     
        //Enable UI
        if (enable == true)
        {
            animator.SetBool("enableUI", true);
            arcDesign1.SetActive(true);
            arcDesign2.SetActive(true);
            UIText.SetActive(true);
        }else 
        {
            animator.SetBool("enableUI", false);
            arcDesign1.SetActive(false); 
            arcDesign2.SetActive(false);
            UIText.SetActive(false);
        }

    }

    public void enableUI()
    {
        if(enable == false)
        {
            enable = true;
        }
    }

  
}
