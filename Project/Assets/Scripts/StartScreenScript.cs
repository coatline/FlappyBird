using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenScript : MonoBehaviour {

    static bool sawOnce = false;
    Renderer renderer;

    void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

	// Use this for initialization
	void Start () {
        if (!sawOnce)
        {
            renderer.enabled = true;
            Time.timeScale = 0;
        }

        sawOnce = true;

	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale == 0 && Input.anyKeyDown)
        {
            Time.timeScale = 1;
            renderer.enabled = false;
        }
	}
}
