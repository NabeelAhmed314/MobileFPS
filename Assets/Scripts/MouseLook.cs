using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation =0f;

    public FixedTouch1 lookAxis;

    private void Start()
    {
        /*        Cursor.visible = false;*/
        /*        Cursor.lockState = CursorLockMode.Locked;*/
        transform.localRotation = Quaternion.Euler(0f, 45f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = lookAxis.TouchDist.x * mouseSensitivity * Time.deltaTime;
        float mouseY = lookAxis.TouchDist.y * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 45f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
