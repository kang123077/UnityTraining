using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // 초기화
    void Awake() // 게임 오브젝트 생성할 때, 최초 실행, 1번만
    {
        Debug.Log("플레이어 데이터가 준비 되었습니다");
    }

    // 활성화
    void OnEnable() // Awake 보다는 늦게 Start보다는 빨리 실행
                    // 게임 오브젝트가 활성화 되었을 때
    {
        Debug.Log("플레이어가 로그인 하였습니다.");
    }

    // 프레임
    // 물리 연산
    void Start() // 업데이트 시작 직전, 최초 실행 , 1번만
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate() // 물리 연산 업데이트, 1초에 약 50회
                       // 고정된 실행 주기로 CPU사용률 높음 주의
    {
        Debug.Log("이동~");
    }

    // 게임 로직
    void Update() // 게임 로직 업데이트, 환경에 따라 실행 주기 변동 가능
                  // 현재 설정상의 경우 60fps로 실행
    {
        Debug.Log("몬스터 사냥!!");
    }

    void LateUpdate() // 모든 업데이트 끝난 후, 실행 주기 업데이트와 동일
                      // 카메라와 같은 후처리 코드가 들어가는 곳?
    {
        Debug.Log("경험치 획득.");
    }

    // 비활성화
    void OnDisable() // 모든 업데이트가 끝난 후 비활성화 or 삭제될 때 실행
    {
        Debug.Log("플레이어가 로그아웃 하였습니다.");
    }

    // 해체
    void OnDestroy() // 게임 오브젝트가 삭제될 때
                     // Awake의 반대
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}
