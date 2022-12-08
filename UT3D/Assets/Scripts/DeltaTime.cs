using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTime : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        // Time.deltaTime

        // Translate : 벡터에 곱하기
        // transform.Translate(Vec * Time.deltaTime);

        // Vector 함수 : 시간 매개변수에 곱하기
        // Vector3.Lerp(Vec1, Vec2, T * Time.deltaTime);

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal")
            * Time.deltaTime,
            Input.GetAxisRaw("Vertical")
            * Time.deltaTime,
            0);
        transform.Translate(vec);
    }
}
