using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    int score = 0;
    public int health = 5;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontaleInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontaleInput, 0, verticalInput) * speed * Time.fixedDeltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            score += 1;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Trap"))
        {
            health -= 1;
            Debug.Log("Health: " + health);
        }
    }

}
