﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isPlayer1;
    public float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(isPlayer1)
        transform.Translate(0f,Input.GetAxis ("Player1")* speed * Time.deltaTime, 0f);
     else
         transform.Translate(0f,Input.GetAxis ("Player2")* speed * Time.deltaTime, 0f);
    }
}
