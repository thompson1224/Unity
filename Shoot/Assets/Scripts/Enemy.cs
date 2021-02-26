using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
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
        
    }

    // Update is called once per frame
    void Update()
    {
        //1. 방향을 구한다.
        Vector3 dir = Vector3.down;

        //2. 이동하고싶다 공식 p = p0+vt
        transform.position += dir * speed * Time.deltaTime;

    }
}
