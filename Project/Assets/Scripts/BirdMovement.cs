using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdMovement : MonoBehaviour
{
    public float flapSpeed = 100f;
    public float forwardSpeed = 1f;
    Rigidbody2D rb;
    Animator animator;

    bool didFlap = false;

    bool dead = false;

    public bool amazingnessMode = false;

    // Use this for initialization
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        animator = transform.GetComponentInChildren<Animator>();
    }

    // Do graphic & input updates here
    void Update()
    {
        //if(transform.position.x == )
        //score.Points = 10;

        if (Input.anyKeyDown && !dead)
        {
            didFlap = true;
            animator.SetTrigger("Flap");
        }

        if(Input.anyKeyDown && dead)
        {
            Time.timeScale = 0;
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.buildIndex);
        }
    }
    //k + c =comment out  k + d = 
    // do physics engine updates here
    // Update is called once per frame
    void FixedUpdate()
    {

        if (dead)
        {
            return;
        }

        rb.AddForce(Vector2.right * forwardSpeed);

        if (didFlap)
        {

            rb.AddForce(Vector2.up * flapSpeed);
            didFlap = false;
        }

        if (rb.velocity.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            float angle = Mathf.Lerp(0, -90, -rb.velocity.y / 2.3f);
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (amazingnessMode || collision.tag == "Ceiling")
        if(amazingnessMode)
            return;

        else
        {
            dead = true;
        }
    }
}
