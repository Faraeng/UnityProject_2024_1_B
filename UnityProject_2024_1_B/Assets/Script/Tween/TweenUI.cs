using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Drawing;

public class TweenUI : MonoBehaviour
{
    public float duration = 1f;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();

        image.DOFade(0f, duration)                      //랜덤 설정된 컬러로 트위닝
                .SetEase(Ease.InOutQuad)                              //옵션 값 설정
                .SetAutoKill(false)
                .Pause()
                .OnComplete(() => Debug.Log("UI 완료"));     //익명함수에서 로그 활성화 [() =>]

        image.DOPlay();                             //설정된 트윈을 실행
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
