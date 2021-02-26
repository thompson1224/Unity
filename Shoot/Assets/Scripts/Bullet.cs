﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //1.방향을 구한다
        Vector3 dir = Vector3.up;

        //2. 이동하고싶다 공식 p = p0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }
}
