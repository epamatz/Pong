﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(0,2)==0 ? -1:1;
        float y = Random.Range(0,2)==0 ? -1:1;
        GetComponent<Rigidbody>().velocity = new Vector3(speed * 2 * x, speed * 2 *  y , 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
