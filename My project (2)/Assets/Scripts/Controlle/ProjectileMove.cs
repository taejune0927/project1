using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 IaunchDirection;          //�߻�ü ���⼺ ����

    public enum BULLETTYPE
    {
        PLAYER,
        ENEMY
    }
    
    public  BULLETTYPE bulletType = BULLETTYPE.PLAYER;

    


    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;
        transform.Translate(IaunchDirection * moveAmount);      
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);                       //�浹�� �Ͼ�� �̸��� �����´�.

        if(collision.gameObject.name == "wall")
        {
            GameObject temp = this.gameObject;                      //�� �ڽ��� �����ͼ� temp �� �Է��Ѵ�.
            Destroy(temp);                                          //��ٷ� �ı��Ѵ�
        }

        if (collision.gameObject.name == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;                      //�� �ڽ��� �����ͼ� temp �� �Է��Ѵ�.
            Destroy(temp);                                          //��ٷ� �ı��Ѵ�
        }


    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);                       //�浹�� �Ͼ�� �̸��� �����´�.

        if (other.gameObject.tag == "Wall")
        {
            GameObject temp = this.gameObject;                      //�� �ڽ��� �����ͼ� temp �� �Է��Ѵ�.
            Destroy(temp);                                          //��ٷ� �ı��Ѵ�
        }

        if (other.gameObject.tag == "Monster" && bulletType == BULLETTYPE.PLAYER)                           //���� �浹�� �Ͼ�� ��
        {
            other.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            other.gameObject.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f),
                    0.1f, 10, 1);
            GameObject temp = this.gameObject;                      //�� �ڽ��� �����ͼ� temp �� �Է��Ѵ�.
            Destroy(temp);                                          //��ٷ� �ı��Ѵ�
        }

        if(other.gameObject.tag == "Player" && bulletType == BULLETTYPE.ENEMY)
        {
            other.gameObject.GetComponent<PlayerController>().Player_Damaged(1);
            GameObject temp = this.gameObject;                      //�� �ڽ��� �����ͼ� temp �� �Է��Ѵ�.
            Destroy(temp);
        }


    }
}
