using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Vector3 dir;


    // 필요속성 : 이동속도
    public float speed = 5;

    private void OnCollisionEnter(Collision other)
    {
        //충돌 시작

        //상대 죽고
        Destroy(other.gameObject);

        //나 죽고
        Destroy(gameObject);
    }

    private void OnCollisionStay(Collision other)
    {
        // 충돌 중
    }

    private void OnCollisionExit(Collision other)
    {
        //충돌 끝
    }



    // Start is called before the first frame update
    void Start()
    {

        //0부터 9까지 10개값중에 하다 랜덤        

        int randValue = UnityEngine.Random.Range(0, 10);

        //3보다 작으면 플레이어쪽
        if (randValue<3)
        {
            // 플레이어를 찾아 타겟
            GameObject target = GameObject.Find("Player");

            //방향은
            dir = target.transform.position - transform.position;

            // 방향크기는 1

            dir.Normalize();
        }
        else
        {
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //1. 방향을 구한다.
        //Vector3 dir = Vector3.down;

        //2. 이동하고싶다 공식 p = p0+vt
        transform.position += dir * speed * Time.deltaTime;

    }
}
