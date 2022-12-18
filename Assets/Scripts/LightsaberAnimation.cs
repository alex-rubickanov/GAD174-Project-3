using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsaberAnimation : MonoBehaviour
{
    Animator animator;
    Weapon blade;
    [SerializeField] GameObject bladeButton;
    [SerializeField] GameObject lukeUI;
    [SerializeField] Animator lukePhotoAnimator;
    //[SerializeField] Animator textAnimator;
    [SerializeField] GameObject text;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
        blade = FindObjectOfType<Weapon>();
        
    }
    // Update is called once per frame
    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (!animator.GetBool("State"))
                {
                animator.SetTrigger("On");
                animator.SetBool("State", true);
            } else
            {
                animator.SetTrigger("Off");
                animator.SetBool("State", false);
            }
            
        }
    } */

    public void ButtonPress()
    {
        if (!animator.GetBool("State"))
        {
            animator.SetBool("State", true);
            blade.enabled = true;
            bladeButton.SetActive(true);
            lukeUI.SetActive(true);
        }
        else
        {
            animator.SetBool("State", false);
            blade.enabled = true;
            bladeButton.SetActive(false);
            lukeUI.SetActive(false);
        }
    }


    public void FlipText()
    {
        lukePhotoAnimator.SetTrigger("Flip");
        // textAnimator.SetTrigger("Flip");
        text.SetActive(true);
    }
}
