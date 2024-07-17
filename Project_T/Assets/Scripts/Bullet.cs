using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;    //피해량 변수
    public int per;         //관통 변수

    //변수 초기화
    public void Init(float damage, int per)
    {
        this.damage = damage;
        this.per = per;
    }
}
