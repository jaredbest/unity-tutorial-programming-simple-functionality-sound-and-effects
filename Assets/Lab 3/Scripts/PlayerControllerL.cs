using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerL : MonoBehaviour
{
    float speed = 10;
    float zBound = 6;
    Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
        ConstrainPlayerPosition();
    }

    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    void ConstrainPlayerPosition()
    {
        if (transform.position.z < -zBound)
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);

        if (transform.position.z > zBound)
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
    }
}
