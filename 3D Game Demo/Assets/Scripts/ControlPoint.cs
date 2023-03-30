using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPoint : MonoBehaviour
{
    float xRot, yRot = 0f;

    public Rigidbody ball;

    public float rotationSpeed = 5f;
    public float shootPower = 20f;
    public LineRenderer line;

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.position;

        if (Input.GetMouseButton(1)) {
            xRot += Input.GetAxis("Mouse X") * rotationSpeed;
            yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
            transform.rotation = Quaternion.Euler(-yRot, xRot, 0f);
            line.gameObject.SetActive(true);
            line.SetPosition(0, transform.position);
            line.SetPosition(1, transform.position + transform.forward * 4f);
        }

        if (Input.GetMouseButtonUp(1)) {
            ball.velocity = transform.forward * shootPower;
            line.gameObject.SetActive(false);
        }
    }
}
