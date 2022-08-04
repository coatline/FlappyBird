using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMover : MonoBehaviour
{
    Rigidbody2D playerRb;

    void Awake()
    {
    }

    // Use this for initialization
    void Start()
    {

        GameObject player_go = GameObject.FindGameObjectWithTag("Player");

        if (player_go == null)
        {
            Debug.LogError("couldn't find an object with the tag 'player'!");
            return;
        }

        playerRb = player_go.GetComponent<Rigidbody2D>();
    }
     
    void FixedUpdate()
    {
        float vel = playerRb.velocity.x * .9f;

        transform.position = transform.position + Vector3.right * vel * Time.deltaTime;
    }

}
