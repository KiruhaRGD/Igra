using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Animator animator;
    private bool isAnim;

    private void Start()
    {
        isAnim = false;
        animator = GetComponent<Animator>();
    }

    public void Interact()
    {
        if (isAnim)
            animator.CrossFade("Down", 0.2f);
        else
        {
            animator.CrossFade("Up", 0.2f);
        }

        isAnim = !isAnim;
    }
}
