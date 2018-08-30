﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float mSpeed;
    private Vector3 spawn;

    // Use this for initialization
    void Start()
    {
        spawn = transform.position;
        mSpeed = 7f;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(mSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, mSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
