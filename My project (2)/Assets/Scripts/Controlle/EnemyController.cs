using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;                        //���� �ӵ� ����
    public float rotationSpeed = 1.0f;

    public GameObject bulletPrefad;                  //�Ѿ� ������
    public GameObject enemyPiovt;                    //�� ��ž

    public Transform firePoint;
    public float fireRate = 1.0f;
    public float nextFireTime;
   
    private Rigidbody rd;                            //Rigidbody ����
    private Transform player;                        //�÷��̾� ��ġ �������� ���� ����

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();                  //�����Ҷ� �ڱ� �ڽ��� Rigidbody �� �޾ƿ´�.
        player = GameObject.FindGameObjectWithTag("Player").transform;        //Scene���� Player Tag�� ���� ������Ʈ�� �����ͼ� Transform �� ����
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            if (Vector3.Distance(player.position, transform.position) > 1.0f)
            {
                Vector3 direction = (player.position - transform.position).normalized;
                rd.MovePosition(transform.position + direction * speed * Time.deltaTime);
            }

            //��ž ȸ��
            Vector3 targetDirection = (player.position - enemyPiovt.transform.position).normalized;
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            enemyPiovt.transform.rotation = Quaternion.Lerp(enemyPiovt.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            if (Time.time > nextFireTime)
            {
                nextFireTime = Time.time + 1.0f / fireRate;
                GameObject temp = (GameObject)Instantiate(bulletPrefad, firePoint.position, firePoint.rotation);
                temp.GetComponent<ProjectileMove>().IaunchDirection = firePoint.localRotation * Vector3.forward;
                temp.GetComponent<ProjectileMove>().bulletType = ProjectileMove.BULLETTYPE.ENEMY;
            }
        }
        

    }





}
