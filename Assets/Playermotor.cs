﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermotor : MonoBehaviour
{
    public GameObject player;
    public Transform destinationPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime;

     
    }
}
