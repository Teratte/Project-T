using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float gameTime; // ���� ���� �ð�
    public float maxGameTime = 2 * 10f; // �ִ� ���� �ð� �׽�Ʈ�� ������ 20��

    public PoolManager pool;
    public PlayerController player;

    void Awake()
    {
        instance = this;    
    }
    void Update()
    {
        gameTime += Time.deltaTime;
        if (gameTime > maxGameTime)
        {
            gameTime = maxGameTime;
        }
    }
}
