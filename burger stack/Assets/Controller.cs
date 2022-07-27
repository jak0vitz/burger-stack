using UnityEngine;

public class Controller : MonoBehaviour
{
    Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    Rigidbody2D rb;
    Vector2 position = new Vector2(0f, 0f);

    public float xRange;
    public float NegativexRange;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x < NegativexRange)
        {
            transform.position = new Vector3(NegativexRange, transform.position.y, transform.position.z);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }
}
