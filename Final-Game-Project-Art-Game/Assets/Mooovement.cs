﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mooovement : MonoBehaviour
{ 
    [SerializeField]
    private float speed = 1;


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical);

        transform.position += movement * Time.deltaTime * speed;
    }

    private void Respawn ()
    {
        float respawnX = -22;
        float respawnY = 0; 

    }
    


}

