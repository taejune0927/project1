using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_005 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //for(int i = 0; i < 5; i++)
        //{
        //    Debug.Log(i);
        //}
       
        //for (int i = 0; i < 10; i += 2)
        //{
        //    Debug.Log(i);
        //}

        //for (int i = 3; i > 0; i--)
        //{
        //    Debug.Log(i);
        //}

        for (int i = 0; i < 10; i++)               //0���� 9���� ¦�� ���
        {
            if(i%5 == 0)                           //%�� ������ ��
            {
                Debug.Log(i);
            }
        }

        Debug.Log("===================================");

        int sum = 0;
        for(int i = 0; i < 10; i++)                 //0���� 9���� �հ� ���
        {
            sum += i;
        }
        Debug.Log(sum);

        Debug.Log("===========������============");

        for(int i = 0; i < 10; i++)                   // i �� 1���� 10����
        {
            for(int j = 1; j < 10; j++)               //j �� 1���� 10����
            {
                Debug.Log(i.ToString() + " x " + j.ToString() + " = " + (i * j).ToString()); // i x j = ���� ��
            }
        }

       //�ּ� ����Ű�� ctrl + K + C , �ּ� Ǯ��� ctrl + K + U
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
