using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{

    public Transform lookAt;
    public bool CamEnabled = false;
    public float sensitivity = 1f;
    public float distance = 20f;
    public Vector2 currentMousePos;


    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space) )
        {
            if ( CamEnabled )
            {
                CamEnabled = false;
                Debug.Log("Camera Movement set to " + CamEnabled);
                Cursor.lockState = CursorLockMode.None;
            }
            else if ( !CamEnabled )
            {
                CamEnabled = true;
                Debug.Log("Camera Movement set to " + CamEnabled);
                Cursor.lockState = CursorLockMode.Confined;
            };
        };
        
        if ( CamEnabled )
        {
            currentMousePos = Input.mousePosition;

            Quaternion rotation = Quaternion.Euler(currentMousePos.y * .2f, currentMousePos.x * -.25f, 0);

            transform.position = lookAt.position - rotation * (Vector3.forward * distance);
            transform.rotation = rotation;
        };
    }

}
