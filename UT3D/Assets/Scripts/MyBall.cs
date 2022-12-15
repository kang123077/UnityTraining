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
        // �Ϲ������� �ɸ��Ϳ� ������ ���� �� �� ������ ���� Impulse���
        // ���԰� ����ϸ� �� ū ���� �ʿ�� ��
        // rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
    }

    // ���� ���� ���ؼ��� FixedUpdate�� �ۼ�
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
