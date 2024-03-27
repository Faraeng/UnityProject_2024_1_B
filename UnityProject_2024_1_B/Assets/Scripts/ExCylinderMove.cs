using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCylinderMove : MonoBehaviour
{
    public float MoveSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //해당 스크립트가 붙어있는 오브젝트는 X축 마이너스 방향으로 이동한다.
        // +는 x += 7 <- x = x + 7 축약 해주는 표시
        // Vector3는 x,y,z 축을 나타내는 변수
        // 프레임 시작 단위 (Time.deltaTime) 모든 컴푸터에서 일정하게 이동을 시켜야 하기 때문에 사용
        //컴퓨터마다 프레임이 다르기 때문
        this.gameObject.transform.position += new Vector3(-1.0f, 0.0f, 0.0f) * Time.deltaTime * MoveSpeed;

        if(gameObject.transform.position.x < -12)    //x축 좌표가 -12 미만으로 내려갈 때
        {
           gameObject.transform.position += new Vector3(24.0f, 0.0f, 0.0f); //오른쪽으로 X축 24만큼 이동
        }
    }
}
