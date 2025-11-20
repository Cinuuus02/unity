using UnityEngine;

public class zad4 : MonoBehaviour
{
    public float launchForce = 15f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * launchForce, ForceMode.Impulse);
            }
        }
    }
}
