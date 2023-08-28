using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontaleInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontaleInput, 0, verticalInput) * speed * Time.fixedDeltaTime;
        transform.Translate(movement);
        
    }
}
