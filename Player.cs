using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bowlingBall;
    public float ballDistance = 2.5f;
    public float ballThrowingForce = 200f;

    public bool holding = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (holding)
        {
            bowlingBall.transform.position = transform.position + transform.forward * ballDistance;
                if (GvrViewer.Instance.Triggered || Input.GetKeyDown("space"))
            {
                    holding = false;
                    bowlingBall.GetComponent<Rigidbody>().useGravity = true;
                    bowlingBall.GetComponent<Rigidbody>().AddForce(transform.forward * ballThrowingForce);
            }
        }
        
    }
}
