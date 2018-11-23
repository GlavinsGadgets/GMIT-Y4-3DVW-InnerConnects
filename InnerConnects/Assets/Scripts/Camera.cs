using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Transform lookAt;
    public bool CamEnabled = true;
    public float sensitivity = 3f;
    public float distance = 15f;

    private Vector3 currentMouse;
    private Vector3 cursorDirection;

    private void Update()
    {
        currentMouse = Input.mousePosition * sensitivity;
        currentMouse.y *= -1f;

        cursorDirection = lookAt.position - transform.position;

        if (CamEnabled)
        {
            Quaternion rotation = Quaternion.Euler(currentMouse.y * .1f, currentMouse.x * -.05f, 0);

            transform.position = lookAt.position - rotation * (Vector3.forward * distance);
            transform.rotation = rotation;
        }
    }

}
