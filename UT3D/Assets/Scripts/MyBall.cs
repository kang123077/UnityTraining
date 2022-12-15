using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        // rigid.velocity = Vector3.left;
        // rigid.velocity = new Vector3(2, 4, 3);
        // 일반적으로 케릭터에 점프를 구현 할 때 다음과 같이 Impulse사용
        // 무게가 상승하면 더 큰 힘이 필요로 함
        // rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
    }

    // 물리 현상에 대해서는 FixedUpdate에 작성
    void FixedUpdate()
    {
        // rigid.velocity = Vector3.left;
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);
    }
}
