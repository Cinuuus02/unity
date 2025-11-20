using UnityEngine;

public class zad2 : MonoBehaviour
{
    public Vector3 openPosition;
    public float speed = 2f;
    private Vector3 closedPosition;
    private bool isOpen = false;
    void Start()
    {
        closedPosition = transform.position;
    }
    void Update()
    {
        Vector3 target = isOpen ? openPosition : closedPosition;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpen = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpen = false;
        }
    }
}
