using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float bulletSpeed = 5f; // 총알 속도
    private Vector2 targetDirection; // 플레이어를 향한 방향

    void Start()
    {
        // 플레이어의 위치 가져오기
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            Vector2 playerPos = player.transform.position;
            Vector2 bulletPos = transform.position;

            // 플레이어를 향한 방향 계산
            targetDirection = (playerPos - bulletPos).normalized;
        }
        else
        {
            // 플레이어가 없는 경우 기본 방향 (필요시 설정)
            targetDirection = Vector2.right;
        }

        Destroy(gameObject, 10f);
    }

    void Update()
    {
        // 총알을 플레이어를 향해 이동
        transform.Translate(targetDirection * bulletSpeed * Time.deltaTime);
    }
}

