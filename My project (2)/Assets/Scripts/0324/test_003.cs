using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_003 : MonoBehaviour
{
    public int herbNum = 1;

    // Start is called before the first frame update
    void Start()
    {
        if(herbNum == 1)
        {
            Debug.Log("ü���� 50 ȸ��"); 
        }
        else
        {
            Debug.Log("ü�� -50 ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
