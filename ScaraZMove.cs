using UnityEngine;

public class ScaraZMove : MonoBehaviour
{
    public GameObject link4;
    public float speed = 2f;

    void Update()
    {
        // Move link4 upward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            link4.transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        }

        // Move link4 downward
        if (Input.GetKey(KeyCode.DownArrow))
        {
            link4.transform.Translate(Vector3.back * speed * Time.deltaTime, Space.Self);
        }
    }
}
