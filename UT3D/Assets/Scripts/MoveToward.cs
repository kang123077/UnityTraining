using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveToward : MonoBehaviour
{
    // Ŭ�������� �����ϴ� �̵� �Լ�
    Vector3 target = new Vector3(8, 2.69f, 0.2576958f);
    void Update()
    {
        // 1. MoveTowards : ��� �̵�

        // (���� ��ġ, ��ǥ ��ġ, �ӵ�)
        // ������ �Ű������� ����Ͽ� �ӵ� ����

        // transform.position =
        //     Vector3.MoveTowards(transform.position, target, 1f);


        // 2. SmoothDamp : �ε巯�� ���� �̵�

        // (���� ��ġ, ��ǥ ��ġ, ���� �ӵ�, �ӵ�)
        // ������ �Ű������� �ݺ���Ͽ� �ӵ� ����
        // ���� �ӵ��� ��� ����� ����� �� �Ⱦ�

        // Vector3 velo = Vector3.zero;

        // transform.position =
        //     Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);


        // 3. Lerp : ���� ����, SmoothDamp���� ���ӽð��� ��

        // (���� ��ġ, ��ǥ ��ġ, �ӵ�)
        // ������ �Ű������� ����Ͽ� �ӵ� ����

        // transform.position =
        //     Vector3.Lerp(transform.position, target, 0.05f);

        // 4. SLerp : ���� ���� ����, ȣ�� �׸��� �̵�

        // (���� ��ġ, ��ǥ ��ġ, �ӵ�)
        // ������ �Ű������� ����Ͽ� �ӵ� ����

        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f);
    }
}
