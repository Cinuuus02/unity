using UnityEngine;

public class zad6_1 : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3f;
    private float yVelocity = 0.0f;

    void Update()
    {

        float newY = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, smoothTime);

        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
