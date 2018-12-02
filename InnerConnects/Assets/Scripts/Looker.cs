using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{
    //Script to allow the player to look around the game pieces.

    public Transform lookAt;
    public bool CamEnabled = false;
    public float sensitivity = 1f;
    public float distance = 20f;
    public Vector2 currentMousePos;


    void Update()
    {
        // if-else statement to check the current state of the camera look.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // If the cameras enabled and the player presses the space bar then the camera look will be disabled and the mouse will be unlocked
            if (CamEnabled)
            {
                CamEnabled = false;
                // Debug.Log("Camera Movement set to " + CamEnabled);
                Cursor.lockState = CursorLockMode.None;
            }
            // If the cameras disabled and the player presses the space bar then the camera look will be enabled and the mouse will be confined within the window
            else if (!CamEnabled)
            {
                CamEnabled = true;
                // Debug.Log("Camera Movement set to " + CamEnabled);
                Cursor.lockState = CursorLockMode.Confined;
            };
        };
        // If the camera look is enabled it will allow the user to look around the gameobject.
        if (CamEnabled)
        {
            currentMousePos = Input.mousePosition;

            Quaternion rotation = Quaternion.Euler(currentMousePos.y * .2f, currentMousePos.x * -.25f, 0);

            transform.position = lookAt.position - rotation * (Vector3.forward * distance);
            transform.rotation = rotation;
        };
    }

}
