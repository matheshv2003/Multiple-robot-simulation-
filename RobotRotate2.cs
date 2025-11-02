using UnityEngine;

public class RobotRotate2 : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        float rotateInput = 0f;

        // Use J and L instead of arrow keys
        if (Input.GetKey(KeyCode.J)) rotateInput = -1f;
        if (Input.GetKey(KeyCode.L)) rotateInput = 1f;

        transform.Rotate(Vector3.forward * rotateInput * rotationSpeed * Time.deltaTime);
    }
}
