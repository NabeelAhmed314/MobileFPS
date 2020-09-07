using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 12f;
    public Vector3 velocity;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundRadius= 0.4f;
    public LayerMask groundMask;
    public bool isGrounded;
    public Joystick moveJoystick;
    public static float x , z;
    public static Vector3 move;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position , groundRadius ,groundMask);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        /*        x = moveJoystick.Horizontal;
                z = moveJoystick.Vertical;*/
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
