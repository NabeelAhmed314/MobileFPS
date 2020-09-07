using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("InputX",PlayerMovement3D.x);
        animator.SetFloat("InputY",PlayerMovement3D.z);
        animator.SetFloat("Speed", PlayerMovement3D.move.sqrMagnitude);
    }
}
