using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float bulletSpeed = 5f; // �Ѿ� �ӵ�
    private Vector2 targetDirection; // �÷��̾ ���� ����

    void Start()
    {
        // �÷��̾��� ��ġ ��������
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            Vector2 playerPos = player.transform.position;
            Vector2 bulletPos = transform.position;

            // �÷��̾ ���� ���� ���
            targetDirection = (playerPos - bulletPos).normalized;
        }
        else
        {
            // �÷��̾ ���� ��� �⺻ ���� (�ʿ�� ����)
            targetDirection = Vector2.right;
        }

        Destroy(gameObject, 10f);
    }

    void Update()
    {
        // �Ѿ��� �÷��̾ ���� �̵�
        transform.Translate(targetDirection * bulletSpeed * Time.deltaTime);
    }
}

