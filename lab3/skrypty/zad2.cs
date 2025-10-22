using UnityEngine;

public class zad2 : MonoBehaviour
{
    public float speed = 2.0f;
    private Vector3 startPos;
    private Vector3 targetPos;
    private bool movingForward = true;

    void Start()
    {
        startPos = transform.position;
        targetPos = startPos + new Vector3(10f, 0f, 0f);
    }

    void Update()
    {
        if (movingForward)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            if (transform.position == targetPos)
                movingForward = false;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPos, speed * Time.deltaTime);
            if (transform.position == startPos)
                movingForward = true;
        }
    }
}
