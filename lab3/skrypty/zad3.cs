using UnityEngine;

public class zad3 : MonoBehaviour
{
    public float speed = 2.0f;
    private Vector3 startPos;
    private Vector3[] points;
    private int targetIndex = 1;
    private bool hasRotated = false;

    void Start()
    {
        startPos = transform.position;
        points = new Vector3[4];
        points[0] = startPos;
        points[1] = startPos + new Vector3(10f, 0f, 0f);
        points[2] = points[1] + new Vector3(0f, 0f, 10f);
        points[3] = points[2] + new Vector3(-10f, 0f, 0f);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[targetIndex], speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, points[targetIndex]) < 0.01f)
        {
            if (!hasRotated)
            {
                transform.Rotate(0f, -90f, 0f);
                hasRotated = true;
                targetIndex = (targetIndex + 1) % points.Length;
            }
        }
        else
        {
            hasRotated = false;
        }
    }
}
