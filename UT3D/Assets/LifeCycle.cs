using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // �ʱ�ȭ
    void Awake() // ���� ������Ʈ ������ ��, ���� ����, 1����
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ� �Ǿ����ϴ�");
    }

    // Ȱ��ȭ
    void OnEnable() // Awake ���ٴ� �ʰ� Start���ٴ� ���� ����
                    // ���� ������Ʈ�� Ȱ��ȭ �Ǿ��� ��
    {
        Debug.Log("�÷��̾ �α��� �Ͽ����ϴ�.");
    }

    // ������
    // ���� ����
    void Start() // ������Ʈ ���� ����, ���� ���� , 1����
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    void FixedUpdate() // ���� ���� ������Ʈ, 1�ʿ� �� 50ȸ
                       // ������ ���� �ֱ�� CPU���� ���� ����
    {
        Debug.Log("�̵�~");
    }

    // ���� ����
    void Update() // ���� ���� ������Ʈ, ȯ�濡 ���� ���� �ֱ� ���� ����
                  // ���� �������� ��� 60fps�� ����
    {
        Debug.Log("���� ���!!");
    }

    void LateUpdate() // ��� ������Ʈ ���� ��, ���� �ֱ� ������Ʈ�� ����
                      // ī�޶�� ���� ��ó�� �ڵ尡 ���� ��?
    {
        Debug.Log("����ġ ȹ��.");
    }

    // ��Ȱ��ȭ
    void OnDisable() // ��� ������Ʈ�� ���� �� ��Ȱ��ȭ or ������ �� ����
    {
        Debug.Log("�÷��̾ �α׾ƿ� �Ͽ����ϴ�.");
    }

    // ��ü
    void OnDestroy() // ���� ������Ʈ�� ������ ��
                     // Awake�� �ݴ�
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }
}
