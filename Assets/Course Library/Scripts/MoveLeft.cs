﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    PlayerController playerControllerScript;

    float speed = 30;
    float leftBound = -15;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (playerControllerScript.gameOver == false)
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
            Destroy(gameObject);
    }
}
