using UnityEngine;

public class zad5 : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Zderzenie z przeszkodą");
        }
    }
}
