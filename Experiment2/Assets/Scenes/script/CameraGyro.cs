using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGyro : MonoBehaviour
{
    public GameObject Camera;
    //移動スピード
    //public float speed = 20.0f;
    //回転スピード
    public float rotateSpeed = 100.0f;
    void Start()
    {
        //Input.gyro.enabled = true;
    }

    void Update()
    {

        float angle = Input.GetAxis("Horizontal") * rotateSpeed;

        Vector3 cameraPos = Camera.transform.position;

        transform.RotateAround(cameraPos, Vector3.up, angle); 

        /*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        */
        //transform.rotation = Quaternion.Euler(0, 0, -180) * Quaternion.Euler(-90, 0, 0) * Input.gyro.attitude * Quaternion.Euler(0, 0, 180);
    }
}