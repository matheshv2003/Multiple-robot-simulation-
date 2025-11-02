using UnityEngine;

public class RobotRotate : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        float rotateInput = Input.GetAxis("Horizontal"); // left/right arrows
        transform.Rotate(Vector3.forward * rotateInput * rotationSpeed * Time.deltaTime);

    }
}
