using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class Test
//{
//    int Number;

//    public void Func
//    {
//        Number = 1000;
//    }
//}


// 파일명과 동일한 클래스가 하나라도 있고
// : MonoBehavior을 상속받아야 스크립트로서
// GameObject에 넣어주는 것이 가능하다.
public class Player : MonoBehaviour
{

    Player()
    {
        UnityEngine.Debug.Log("생성자");
    }

    void Awake()
    {
        UnityEngine.Debug.Log("생성함수");
    }

    // Start is called before the first frame update
    void Start()
    {
        //Test NewTest = null;

        //NewTest.Func();

        UnityEngine.Debug.Log("시작함수");

        //this는 현재 플레이어 스크립트 그 자체의 레퍼런스이다.

        Transform MyTrans = GetComponent<Transform>();

        if (null == MyTrans)
        {
            Debug.Log("트랜스폼이 없음");
            return;
        }

        // 벡터는 x,y,z 값
        //MyTrans.position = new Vector3(2, 0, 0);

        SpriteRenderer SR = GetComponent<SpriteRenderer>();

        if(null == SR)
        {
            Debug.Log("스프라이트 랜더러가 없음");
            return;
        }

        Status STATUS = GetComponent<Status>();

        if(null == STATUS)
        {
            Debug.Log("스테이터스가 없어요");
            return;
        }

        Debug.Log("현재 공격력 스테이터스" + STATUS.AT);
        STATUS.AT = 5000;
        Debug.Log("변경된 공격력 스테이터스" + STATUS.AT);

        // 색상 RGBA 0~0.1
        SR.color = new Color(0.0f, 0.0f, 0.0f, 0.5f);

        SR.flipX = true;
    }

    // Update is called once per frame
    void Update()
    {
        // 게임이 실행해줄 수 있는 프레임의 최대한도로 update를 해준다
        // Debug.Log("업데이트");

        // 벡터의 덧셈
        // 0,0,0
        //+1,0,0
        //=1,0,0
        //+1,0,0
        //=2,0,0
        // x는 x끼리, y는 y끼리, z는 z끼리 더한다
        transform.position += new Vector3(0.1F, 0.1F, 0.0F);
    }
}
