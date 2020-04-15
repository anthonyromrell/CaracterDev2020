using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AddForces : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float forceValue = 10;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!other.transform.CompareTag("Player")) return;
        var direction = (other.transform.position - transform.position).normalized;
        rigidbody.AddForce (direction * -forceValue);
    }
}
