using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //UI를 사용하기 위해 추가

public class ExMouseButton : MonoBehaviour
{
    public int HP = 100;
    public Text textUI;    //UI 글씨 문자열 추가

    // Update is called once per frame
    void Update()
    {
        Debug.Log("체력 : " + HP);
        if (Input.GetMouseButtonDown(0)) //마우스 입력이 들어왔을 때
        {
            HP -= 10;
            Debug.Log("체력 : " + HP.ToString());   //체력 확인을 위한 Debug.Log 함수
            if (HP <= 0)     // HP가 0이하로 내려가면
            {
                Destroy(gameObject);     //이 오브젝트를 파괴한다는 함수
            }
        }
    }
}
