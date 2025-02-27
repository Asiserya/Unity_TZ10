using UnityEngine;

public class AddForces : MonoBehaviour
{
    public float bounceForce = 5f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 normal = collision.contacts[0].normal;
                rb.linearVelocity = Vector3.Reflect(rb.linearVelocity, normal);
            }
        }
    }
}
