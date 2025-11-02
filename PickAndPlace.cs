using UnityEngine;

public class PickAndPlace : MonoBehaviour
{
    public Transform holdPoint;
    public float grabRadius = 1f;
    public KeyCode pickKey = KeyCode.P;
    public KeyCode placeKey = KeyCode.O;

    private GameObject heldObject;

    void Update()
    {
        if (Input.GetKeyDown(pickKey))
        {
            if (heldObject == null) TryPickObject();
        }

        if (Input.GetKeyDown(placeKey))
        {
            if (heldObject != null) PlaceObject();
        }
    }

    void TryPickObject()
    {
        Debug.Log("P pressed – checking nearby objects...");
        Collider[] hits = Physics.OverlapSphere(transform.position, grabRadius);

        foreach (var hit in hits)
        {
            if (hit.CompareTag("Pickable"))
            {
                Debug.Log("Picked " + hit.name);
                heldObject = hit.gameObject;
                heldObject.transform.SetParent(holdPoint);
                heldObject.transform.localPosition = Vector3.zero;
                var rb = heldObject.GetComponent<Rigidbody>();
                if (rb) rb.isKinematic = true;
                return;
            }
        }
    }

    void PlaceObject()
    {
        Debug.Log("Placing " + heldObject.name);
        heldObject.transform.SetParent(null);
        var rb = heldObject.GetComponent<Rigidbody>();
        if (rb) rb.isKinematic = false;
        heldObject = null;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, grabRadius);
    }
}
