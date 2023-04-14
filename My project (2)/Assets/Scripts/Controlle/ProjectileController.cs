using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public Vector3 IaunchDirection;                             //�߻� ���� ���� ����
    public GameObject Projectile;                               //�߻�ü ������ ����

    public void FireProjectile()                                // �߻� �Լ� ����
    {
        GameObject temp = (GameObject)Instantiate(Projectile);  //�߻�ü �������� ���� ��Ű�� temp �� �Է�
                                                                //Instantiate �Լ��� GameObject , �������� ���� ��Ų��.
        temp.transform.position = this.gameObject.transform.position;
        temp.GetComponent<ProjectileMove>().IaunchDirection = transform.forward;

        Destroy(temp, 10f);    //�߻�ü ������� 10���Ŀ� �������.



    }
    
    
}
