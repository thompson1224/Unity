﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    float currentTime;

    //일정 시간

    public float createTime = 1;

    // 적 공장

    public GameObject enemyFactory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > createTime)
        {
            //3. 적 공장에서 적 생성
            GameObject enemy = Instantiate(enemyFactory);

            // 내위치에
            enemy.transform.position = transform.position;

            // 현재시간 0 초기화
            currentTime = 0;
        }


    }
}
