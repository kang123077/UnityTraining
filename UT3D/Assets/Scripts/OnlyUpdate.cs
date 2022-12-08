using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyUpdate : MonoBehaviour
{
    void Update()
    {
        // Input = 게임 내 입력을 관리하는 클래스
        // anyKeyDown = 아무 입력을 최초로 받을 때 True
        // anyKeyDown = 아무 입력을 받을 때 True
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.anyKey)
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");

        // Return = Enter. Enter는 없음
        // KeypadEnter는 있음
        // Down = 키를 누를 때
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구매하였습니다.");

        // 키를 누르는 동안
        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");

        // Up = 키를 땔 때
        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");

        if (Input.GetMouseButtonDown(0))
            Debug.Log("공격");

        if (Input.GetMouseButton(0))
            Debug.Log("차지 중");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("차지 공격");

        // 기본 설정값인 GetButton에서 Jump, Fire1 등 받을 수 있음
        // 일반적인 경우 차지 행동에서는 Down은 안 씀
        // 대소문자 사용에 주의 할 것
        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!");

        if (Input.GetButton("Jump"))
            Debug.Log("점프 차지 중...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");

        // 더 추가하고 싶을 시
        // Edit > ProjectSetting > InputManager
        // 사이즈를 늘린 후 새로 키를 설정할 수 있다

        // 가중치를 가진 전달 GetAxis (가속도 존재)
        // GetAxisRaw는 가중치가 없다 (슉 이동함)
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중..." 
                + Input.GetAxis("Horizontal"));
        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중..."
                + Input.GetAxisRaw("Vertical"));
        }
    }
}
