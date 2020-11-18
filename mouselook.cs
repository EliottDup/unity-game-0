using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    public Transform playerBody;
    public float mouseSensitivity = 100f;
    float xRotarion = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotarion -= mouseY;
        xRotarion = Mathf.Clamp(xRotarion, -90, 90);

        transform.localRotation = Quaternion.Euler(xRotarion, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
