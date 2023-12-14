using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.visible = false;
    }

    // Update is called once per frame
    int speed = 3;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float hori = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(hori, 0, vert);
        transform.Translate(movement * speed * Time.deltaTime);
        Vector3 jump = new Vector3 (0, 1, 0);
        if(Input.GetKeyDown("space")){
            transform.Translate(jump * speed * Time.deltaTime);
        }
        yaw += speed * Input.GetAxis("Mouse X");
        pitch -= speed * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);//pitch, yaw, 0.0f);
    }
}
