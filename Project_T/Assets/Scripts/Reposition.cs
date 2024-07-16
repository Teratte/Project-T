using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Area"))
            return;

        Vector3 playerPos = GameManager.instance.player.transform.position; // 플레이어의 포지션
        Vector3 myPos = transform.position; // 타일맵 위치
        float diffX = Mathf.Abs(playerPos.x - myPos.x); // 거리 값 차이(절댓값 사용)
        float diffY = Mathf.Abs(playerPos.y - myPos.y);

        Vector3 playerDir = GameManager.instance.player.inputVec; // 플레이어의 방향
        float dirX = playerDir.x < 0 ? -1 : 1; // 방향 값 차이
        float dirY = playerDir.y < 0 ? -1 : 1;

        switch(transform.tag)
        {
            case "Ground":
                if(diffX > diffY)
                {
                    transform.Translate(Vector3.right * dirX * 40);
                }
                else if(diffX < diffY)
                {
                    transform.Translate(Vector3.up * dirY * 40);
                }
                break;
            case "Enemy":
                // 로직
                break;
        }
    }
}
