using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float horizontalSpeed = 1f;
    public float verticalSpeed = 1f;
    public GameObject sword;
    public float distance = 1f;

    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    private Camera cam;
 
    void Start()
    {
        cam = Camera.main;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
 
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;
 
        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
 
        cam.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);
    }
}
