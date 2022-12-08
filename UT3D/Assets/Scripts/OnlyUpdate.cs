using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyUpdate : MonoBehaviour
{
    void Update()
    {
        // Input = ���� �� �Է��� �����ϴ� Ŭ����
        // anyKeyDown = �ƹ� �Է��� ���ʷ� ���� �� True
        // anyKeyDown = �ƹ� �Է��� ���� �� True
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.anyKey)
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");

        // Return = Enter. Enter�� ����
        // KeypadEnter�� ����
        // Down = Ű�� ���� ��
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("�������� �����Ͽ����ϴ�.");

        // Ű�� ������ ����
        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�������� �̵� ��");

        // Up = Ű�� �� ��
        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("������ �̵��� ���߾����ϴ�.");

        if (Input.GetMouseButtonDown(0))
            Debug.Log("����");

        if (Input.GetMouseButton(0))
            Debug.Log("���� ��");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� ����");

        // �⺻ �������� GetButton���� Jump, Fire1 �� ���� �� ����
        // �Ϲ����� ��� ���� �ൿ������ Down�� �� ��
        // ��ҹ��� ��뿡 ���� �� ��
        if (Input.GetButtonDown("Jump"))
            Debug.Log("����!");

        if (Input.GetButton("Jump"))
            Debug.Log("���� ���� ��...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("���� ����!!");

        // �� �߰��ϰ� ���� ��
        // Edit > ProjectSetting > InputManager
        // ����� �ø� �� ���� Ű�� ������ �� �ִ�

        // ����ġ�� ���� ���� GetAxis (���ӵ� ����)
        // GetAxisRaw�� ����ġ�� ���� (�� �̵���)
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��..." 
                + Input.GetAxis("Horizontal"));
        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵� ��..."
                + Input.GetAxisRaw("Vertical"));
        }
    }
}
