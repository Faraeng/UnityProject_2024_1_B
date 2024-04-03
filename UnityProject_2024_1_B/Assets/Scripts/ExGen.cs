using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExGen : MonoBehaviour
{
    public GameObject item;     //게임 오브젝트 아이템 정의
    public float checkTime;     //시간값 체크 정의

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
