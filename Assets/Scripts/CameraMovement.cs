using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private float pitch = 0.0f;
    int speed = 5;

    void FixedUpdate()
    {
        pitch -= speed * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, 0.0f, 0.0f);
    }
}
