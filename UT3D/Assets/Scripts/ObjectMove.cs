using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    // Transform : ������Ʈ ���¿� ���� �⺻ ������Ʈ
    void Start()
    {
        // �Ʒ��� ���� �ʱ�ȭ �� �ʿ� ���� �׻� ����
        // Transform tr;
        // Translate �� Transform�� ���� ����
        // Vector3�� 3������ ���� ��
        // x, y, z���� ����(����)����
        Vector3 vec = new Vector3(0, 0, 0);
        transform.Translate(vec);

        // int number = 4; // ��Į�� ��
    }

    void Update() // ��������� 1�� 60ȸ �� ����
    {
        Vector3 vec2 = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxisRaw("Vertical"),
            0);
        transform.Translate(vec2);
    }
}
