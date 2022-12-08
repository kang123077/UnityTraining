using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveToward : MonoBehaviour
{
    // 클래스에서 제공하는 이동 함수
    Vector3 target = new Vector3(8, 2.69f, 0.2576958f);
    void Update()
    {
        // 1. MoveTowards : 등속 이동

        // (현재 위치, 목표 위치, 속도)
        // 마지막 매개변수에 비례하여 속도 증가

        // transform.position =
        //     Vector3.MoveTowards(transform.position, target, 1f);


        // 2. SmoothDamp : 부드러운 감속 이동

        // (현재 위치, 목표 위치, 참조 속도, 속도)
        // 마지막 매개변수에 반비례하여 속도 증가
        // 참조 속도의 경우 사용이 어려워 잘 안씀

        // Vector3 velo = Vector3.zero;

        // transform.position =
        //     Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);


        // 3. Lerp : 선형 보간, SmoothDamp보다 감속시간이 김

        // (현재 위치, 목표 위치, 속도)
        // 마지막 매개변수에 비례하여 속도 증가

        // transform.position =
        //     Vector3.Lerp(transform.position, target, 0.05f);

        // 4. SLerp : 구면 선형 보간, 호를 그리며 이동

        // (현재 위치, 목표 위치, 속도)
        // 마지막 매개변수에 비례하여 속도 증가

        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f);
    }
}
