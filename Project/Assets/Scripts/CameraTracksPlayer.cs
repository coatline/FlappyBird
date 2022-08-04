using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracksPlayer : MonoBehaviour
{

    Transform player;
    float xOffSet;

    // Use this for initialization
    void Start()
    {
        GameObject player_go = GameObject.FindGameObjectWithTag("Player");

        if (player_go == null)
        {
            Debug.LogError("couldn't find an object with the tag 'player'!");
            return;
        }

        player = player_go.transform;

        xOffSet = transform.position.x - player.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 pos = transform.position;
            pos.x = player.position.x + xOffSet;
            transform.position = pos;
        }
    }
}
