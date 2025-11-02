using UnityEngine;

public class ScaraZMove2 : MonoBehaviour
{
    public GameObject link4;
    public float speed = 2f;

    void Update()
    {
        // Move link4 upward with W
        if (Input.GetKey(KeyCode.W))
        {
            link4.transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        }

        // Move link4 downward with S
        if (Input.GetKey(KeyCode.S))
        {
            link4.transform.Translate(Vector3.back * speed * Time.deltaTime, Space.Self);
        }
    }
}
