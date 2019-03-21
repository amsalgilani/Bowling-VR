﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinCollisionArea : MonoBehaviour
{
    public Pin pin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.tag == "Floor")
        {
            pin.OnTouchFloor();
        }
    }
}
