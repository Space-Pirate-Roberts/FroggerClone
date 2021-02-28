using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;

    public float minSpeed = 8f, maxSpeed = 12f;

    float speed = 1f;
    float speedMultiplier;

    private void Start()
    {
        speedMultiplier = PlayerPrefs.GetFloat("speed");
        minSpeed = minSpeed * speedMultiplier;
        maxSpeed = maxSpeed * speedMultiplier;
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
        if ((rb.position.x > 15) || (rb.position.x < -15))
        { 
            Destroy (rb.gameObject);
        }
    }
}
