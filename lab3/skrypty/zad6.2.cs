using UnityEngine;

public class zad6_2 : MonoBehaviour
{
    public Transform target;
    public float lerpSpeed = 0.1f;

    void Update()
    {
        float newY = Mathf.Lerp(transform.position.y, target.position.y, lerpSpeed);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
