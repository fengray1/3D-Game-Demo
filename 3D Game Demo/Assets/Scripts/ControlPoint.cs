using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPoint : MonoBehaviour
{
    float xRot, yRot = 0f;

    public Rigidbody ball;

    public float rotationSpeed = 5f;
    public LineRenderer line;

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.position;

        if (Input.GetMouseButton(1)) {
            xRot += Input.GetAxis("Mouse X") * rotationSpeed;
            yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
            if (yRot < -20f) {
                yRot = -20f;
            }
            if (yRot > 20f) {
                yRot = 20f;
            }
            transform.rotation = Quaternion.Euler(-yRot, xRot, 0f);
        }
    }
}
