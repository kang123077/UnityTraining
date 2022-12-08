using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    // Transform : 오브젝트 형태에 대한 기본 컴포넌트
    void Start()
    {
        // 아래와 같이 초기화 할 필요 없이 항상 존재
        // Transform tr;
        // Translate 는 Transform에 값을 전달
        // Vector3는 3차원의 벡터 값
        // x, y, z값을 전달(합해)해줌
        Vector3 vec = new Vector3(0, 0, 0);
        transform.Translate(vec);

        // int number = 4; // 스칼라 값
    }

    void Update() // 평균적으로 1초 60회 씩 동작
    {
        Vector3 vec2 = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxisRaw("Vertical"),
            0);
        transform.Translate(vec2);
    }
}
