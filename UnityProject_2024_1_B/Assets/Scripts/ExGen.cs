using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExGen : MonoBehaviour
{
    public GameObject item;     //���� ������Ʈ ������ ����
    public float checkTime;     //�ð��� üũ ����

    //Update is called once per frame
    void Update()
    {
        checkTime += checkTime.deltaTime;
        if(checkTime > 2.0f)
        {
            GameObject Temp = Intantiate(item);
            Temp.transform.position +=new
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
