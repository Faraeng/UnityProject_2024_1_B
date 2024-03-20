using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //UI�� ����ϱ� ���� �߰�

public class ExMouseButton : MonoBehaviour
{
    public int HP = 100;
    public Text textUI;    //UI �۾� ���ڿ� �߰�

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ü�� : " + HP);
        if (Input.GetMouseButtonDown(0)) //���콺 �Է��� ������ ��
        {
            HP -= 10;
            Debug.Log("ü�� : " + HP.ToString());   //ü�� Ȯ���� ���� Debug.Log �Լ�
            if (HP <= 0)     // HP�� 0���Ϸ� ��������
            {
                Destroy(gameObject);     //�� ������Ʈ�� �ı��Ѵٴ� �Լ�
            }
        }
    }
}
