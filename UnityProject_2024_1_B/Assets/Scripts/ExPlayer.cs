using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                 //UI�� ����ϱ� ���ؼ�

public class ExPlayer : MonoBehaviour
{
    public Rigidbody m_rigibody;      //������ �ٵ� �ҽ��� ����ϰ� �޾� �´�.
    public int Force = 100;        //int ������ ���� 100�� �����Ѵ�.
    public int point = 0;          //���� ����� ���� �߰�
    public float checkTime = 0;   //�ð� ������ ���� ���� (�Ҽ���)
    public Text m_Text;           //UI �ؽ�Ʈ ����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))  //���콺 �Է��� ������ ��
        {
            m_rigibody.AddForce(transform.up * Force);   //transfom.up(�� ����)���� ������ �ٵ� Force ����ŭ ������ ���� �ش�.
        }

        checkTime += Time.deltaTime;  // ������ ������ ���ؼ� �ð��� ����
        if (checkTime >= 1.0f)        //���� 1�ʰ� ������ ���
        {
            point += 1;               // point = point + 1 ��� (1���� ����)
            checkTime = 0.0f;        //1�ʰ� ������ �ʱ�ȭ
        }

        m_Text.text = point.ToString();

    }
    
    

    private void OnCollisionEnter(Collision Collision)                      //�浹�� ���۵Ǿ��� ��
    {
        if (Collision != null)                                               //�浹 ��ü�� ���� ���� ���[ != �ٸ� ��� ]
        {
            point = 0;                                                       //�浹�� �߻����� ���� ����Ʈ�� 0���� ���ش�.
            gameObject.transform.position = new Vector3(0.0f, 3.0f, 0.0f);    //�浹���� �� ��ġ�� �ʱ�ȭ
            Debug.Log(Collision.gameObject.name);                             //�ش� ������Ʈ�� �̸��� Ŭ��
        }


    }
}
  
