using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 IaunchDirection;

    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;
        transform.Translate(IaunchDirection * moveAmount);      
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);                       //충돌이 일어날때 이름을 가져온다.

        if(collision.gameObject.name == "wall")
        {
            GameObject temp = this.gameObject;                      //나 자신을 가져와서 temp 에 입력한다.
            Destroy(temp);                                          //곧바로 파괴한다
        }

        if (collision.gameObject.name == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;                      //나 자신을 가져와서 temp 에 입력한다.
            Destroy(temp);                                          //곧바로 파괴한다
        }


    }
}
