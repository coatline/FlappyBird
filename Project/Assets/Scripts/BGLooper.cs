using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGLooper : MonoBehaviour
{

    int numBGPanels = 6;
    float pipeMax = 1.5f;
    float pipeMin = .1f;

    //void Start()
    //{
    //    var w = new Weapon("mace");
    //    Debug.Log(w.Name);
    //    Debug.Log("Dip mace in water");
    //    w.Rusted = true;
    //    Debug.Log(w.Name);
    //    Debug.Log(w.Hit());
    //}

    void Start()
    {
        GameObject[] pipes = GameObject.FindGameObjectsWithTag("Pipe");

        foreach (GameObject pipe in pipes)
        {
            Vector3 hit = pipe.transform.position;

            hit.y = Random.Range(pipeMin, pipeMax);

            pipe.transform.position = hit;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        //Debug.Log("Triggered " + collider.name);
        float widthOfBGObject = ((BoxCollider2D)collider).size.x;

        Vector3 pos = collider.transform.position;

        pos.x += widthOfBGObject * numBGPanels;

        if (collider.tag == "Pipe")
        {
            pos.y = Random.Range(pipeMin, pipeMax);
        }

        collider.transform.position = pos;

    }
}

//public class Weapon
//{
//    private string condition = "shiny";
//    private string name;

//    public string Name
//    {
//        get
//        {
//            return condition + " " + name;
//        }
//    }

//    private bool rusted;
//    public bool Rusted
//    {
//        get { return rusted; }
//        set
//        {
//            rusted = value;
//            if (rusted)
//                condition = "rusted";
//            else
//                condition = "shiny";
//        }
//    }

//    public Weapon(string weaponName)
//    {
//        name = weaponName;
//    }

//    public string Hit()
//    {
//        return "You hit with a " + Name + " weapon!";
//    }
//}

