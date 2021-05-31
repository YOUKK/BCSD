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


// ���ϸ�� ������ Ŭ������ �ϳ��� �ְ�
// : MonoBehavior�� ��ӹ޾ƾ� ��ũ��Ʈ�μ�
// GameObject�� �־��ִ� ���� �����ϴ�.
public class Player : MonoBehaviour
{

    Player()
    {
        UnityEngine.Debug.Log("������");
    }

    void Awake()
    {
        UnityEngine.Debug.Log("�����Լ�");
    }

    // Start is called before the first frame update
    void Start()
    {
        //Test NewTest = null;

        //NewTest.Func();

        UnityEngine.Debug.Log("�����Լ�");

        //this�� ���� �÷��̾� ��ũ��Ʈ �� ��ü�� ���۷����̴�.

        Transform MyTrans = GetComponent<Transform>();

        if (null == MyTrans)
        {
            Debug.Log("Ʈ�������� ����");
            return;
        }

        // ���ʹ� x,y,z ��
        //MyTrans.position = new Vector3(2, 0, 0);

        SpriteRenderer SR = GetComponent<SpriteRenderer>();

        if(null == SR)
        {
            Debug.Log("��������Ʈ �������� ����");
            return;
        }

        Status STATUS = GetComponent<Status>();

        if(null == STATUS)
        {
            Debug.Log("�������ͽ��� �����");
            return;
        }

        Debug.Log("���� ���ݷ� �������ͽ�" + STATUS.AT);
        STATUS.AT = 5000;
        Debug.Log("����� ���ݷ� �������ͽ�" + STATUS.AT);

        // ���� RGBA 0~0.1
        SR.color = new Color(0.0f, 0.0f, 0.0f, 0.5f);

        SR.flipX = true;
    }

    // Update is called once per frame
    void Update()
    {
        // ������ �������� �� �ִ� �������� �ִ��ѵ��� update�� ���ش�
        // Debug.Log("������Ʈ");

        // ������ ����
        // 0,0,0
        //+1,0,0
        //=1,0,0
        //+1,0,0
        //=2,0,0
        // x�� x����, y�� y����, z�� z���� ���Ѵ�
        transform.position += new Vector3(0.1F, 0.1F, 0.0F);
    }
}
